using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SecureCrypt
{
    public partial class encryption : Form
    {
        private const string ConnectionString =
            @"Data Source=SHOWRAB_LAPTOP\SQLEXPRESS;Initial Catalog=SecureCrypt;Integrated Security=True";

        // Default key when user doesn’t choose a custom one
        private const string DefaultKey = "MyDefaultSecureKey123"; // change for your app

        public encryption()
        {
            InitializeComponent();
        }

        // -------------- UI EVENTS --------------

        private void encryptSecretKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSecretKeyField(encryptSecretKeyCheckBox, encryptSecretKey);
        }

        private void decryptSecretKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSecretKeyField(decryptSecretKeyCheckBox, decryptSecretKey);
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            string plainText = encryptInput.Text;

            if (string.IsNullOrWhiteSpace(plainText))
            {
                CustomMessageBox.ShowMessage("Encryption Failed", "Please enter text to encrypt.");
                return;
            }

            string key;
            if (!TryGetKey(encryptSecretKeyCheckBox, encryptSecretKey, out key))
                return; // message already shown

            try
            {
                string cipherText = EncryptText(plainText, key);
                encryptOutput.Text = cipherText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: " + ex.Message);
            }
        }

        private void decryptButton_Click_1(object sender, EventArgs e)
        {
            string cipherText = decryptInput.Text;

            if (string.IsNullOrWhiteSpace(cipherText))
            {
                CustomMessageBox.ShowMessage("Decryption Failed", "Please enter text to decrypt.");
                return;
            }

            // decide which key to use
            string key;
            if (!TryGetKey(decryptSecretKeyCheckBox, decryptSecretKey, out key))
                return; // message already shown in TryGetKey

            try
            {
                string plainText = DecryptText(cipherText, key);
                DecryptOutput.Text = plainText;
            }
            catch (FormatException)
            {
                CustomMessageBox.ShowMessage("Decryption Failed", "The text is not a valid encrypted value (Base64).");
            }
            catch (CryptographicException)
            {
                CustomMessageBox.ShowMessage("Decryption Failed", "The key might be wrong or the text is corrupted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message);
            }
        }

        // -------------- SHARED HELPERS --------------

        /// <summary>
        /// Enable/disable a secret-key TextBox based on the checkbox.
        /// </summary>
        private void ToggleSecretKeyField(CheckBox checkBox, TextBox keyBox)
        {
            keyBox.Enabled = checkBox.Checked;

            if (!checkBox.Checked)
            {
                keyBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Gets the key string (custom or default). Shows MessageBox if invalid.
        /// </summary>
        private bool TryGetKey(CheckBox useCustomKeyCheckBox, TextBox keyBox, out string key)
        {
            if (useCustomKeyCheckBox.Checked)
            {
                if (string.IsNullOrWhiteSpace(keyBox.Text))
                {
                    CustomMessageBox.ShowMessage("Decryption Failed", "Please enter a secret key or uncheck the box.");
                    key = null;
                    return false;
                }

                key = keyBox.Text;
            }
            else
            {
                key = DefaultKey;
            }

            return true;
        }

        /// <summary>
        /// Creates a 32-byte AES key from the provided string using SHA256.
        /// </summary>
        private byte[] GetKeyBytes(string key)
        {
            using (var sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(key));
            }
        }

        // -------------- CRYPTO METHODS --------------

        private string EncryptText(string plainText, string key)
        {
            byte[] keyBytes = GetKeyBytes(key);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.GenerateIV(); // new IV for each encryption

                using (var ms = new MemoryStream())
                {
                    // prepend IV to the output so we can use it for decryption later
                    ms.Write(aes.IV, 0, aes.IV.Length);

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (var sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private string DecryptText(string cipherText, string key)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherText);
            byte[] keyBytes = GetKeyBytes(key);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;

                // read IV from first 16 bytes (AES block size is 128 bits = 16 bytes)
                byte[] iv = new byte[aes.BlockSize / 8];
                byte[] cipherBytes = new byte[fullCipher.Length - iv.Length];

                Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                Array.Copy(fullCipher, iv.Length, cipherBytes, 0, cipherBytes.Length);

                aes.IV = iv;

                using (var ms = new MemoryStream(cipherBytes))
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string userName = SessionData.CurrentUserEmail.Split('@')[0];

            // Navigate to home page
            home homeForm = new home(userName);
            homeForm.Show();

            // Hide current page
            this.Hide();
        }

        private void dataBankButton_Click(object sender, EventArgs e)
        {
            // 1. Get cipher text and user email
            string cipherText = encryptOutput.Text;
            string email = SessionData.CurrentUserEmail;  // from login

            if (string.IsNullOrWhiteSpace(cipherText))
            {
                CustomMessageBox.ShowMessage("No data to save", "Please encrypt some text first before saving it.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                CustomMessageBox.ShowMessage("User missing", "User email not found. Please sign in again.");
                return;
            }

            // 2. Ask user for a nickname (popup textbox)
            string nickname = Interaction.InputBox(
                "Enter a nickname for this encrypted data:",
                "Save to Data Bank",
                "My Secret Note");   // default text (optional)

            // If user clicks Cancel or leaves it empty, cancel the save
            if (string.IsNullOrWhiteSpace(nickname))
            {
                MessageBox.Show("Save cancelled. No nickname provided.",
                                "Cancelled",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // 3. Save to database using stored procedure
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_SaveUserCipherText", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@CipherText", cipherText);
                    cmd.Parameters.AddWithValue("@Nickname", nickname);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                CustomMessageBox.ShowMessage("Saved", "Encrypted data saved to your Data Bank.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save data: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // 🔹 THIS IS YOUR "GO TO DATA BANK" BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            // Use the current logged-in user's email (from your SessionData)
            string email = SessionData.CurrentUserEmail;

            if (string.IsNullOrWhiteSpace(email))
            {
                CustomMessageBox.ShowMessage("User missing", "User email not found. Please sign in again.");
                return;
            }

            // If your dataBankDatabase form has a constructor that takes email:
            // dataBankDatabase dbPage = new dataBankDatabase(email);

            // If your dataBankDatabase uses SessionData inside it, and has a default constructor,
            // then this line is also fine:
            dataBankDatabase dbPage = new dataBankDatabase();

            dbPage.Show();
            this.Hide();
        }
    }
}
