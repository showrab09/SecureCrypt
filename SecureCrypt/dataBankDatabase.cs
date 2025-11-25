using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SecureCrypt
{
    public partial class dataBankDatabase : Form
    {
        private const string ConnectionString =
            @"Data Source=SHOWRAB_LAPTOP\SQLEXPRESS;Initial Catalog=SecureCrypt;Integrated Security=True";

        private const string DefaultKey = "MyDefaultSecureKey123";

        public dataBankDatabase()
        {
            InitializeComponent();

            dataGridView1.CellContentClick += dataBankGrid_CellContentClick;
            dataGridView1.CellEnter += dataBankGrid_CellEnter;
            dataGridView1.CellLeave += dataBankGrid_CellLeave;
        }

        private void dataBankDatabase_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        // ---------------- LOAD DATA ----------------

        private void LoadUserData()
        {
            string email = SessionData.CurrentUserEmail;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("User email not found. Please sign in again.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = email.Split('@')[0];
            lblTitle.Text = $"Data Bank for {userName.ToUpper()}";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Nickname, CipherText, CreatedAt " +
                    "FROM UserCipherData " +
                    "WHERE Email = @Email " +
                    "ORDER BY CreatedAt DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                if (!dt.Columns.Contains("SecretKey"))
                    dt.Columns.Add("SecretKey", typeof(string));

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;

                // Hide Id
                if (dataGridView1.Columns.Contains("Id"))
                    dataGridView1.Columns["Id"].Visible = false;

                // Friendly names
                dataGridView1.Columns["Nickname"].HeaderText = "Nick Name";
                dataGridView1.Columns["CipherText"].HeaderText = "Cypher Text";
                dataGridView1.Columns["SecretKey"].HeaderText = "Secret Key";

                // Hide CreatedAt
                if (dataGridView1.Columns.Contains("CreatedAt"))
                    dataGridView1.Columns["CreatedAt"].Visible = false;

                // Order
                dataGridView1.Columns["Nickname"].DisplayIndex = 0;
                dataGridView1.Columns["CipherText"].DisplayIndex = 1;
                dataGridView1.Columns["SecretKey"].DisplayIndex = 2;

                // Style
                dataGridView1.BorderStyle = BorderStyle.None;
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView1.DefaultCellStyle.BackColor = Color.White;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Secret Key placeholder
                var secretCol = dataGridView1.Columns["SecretKey"];
                if (secretCol != null)
                {
                    secretCol.DefaultCellStyle.BackColor = Color.FromArgb(230, 240, 255);
                    secretCol.DefaultCellStyle.ForeColor = Color.DimGray;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        row.Cells["SecretKey"].Value = "Secret Key";
                }

                // Add DECRYPT + DELETE buttons
                AddActionColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddActionColumns()
        {
            // ----- DECRYPT BUTTON (green) -----
            const string decryptColName = "DecryptButton";
            if (!dataGridView1.Columns.Contains(decryptColName))
            {
                DataGridViewButtonColumn decryptCol = new DataGridViewButtonColumn
                {
                    Name = decryptColName,
                    HeaderText = "Decrypt",
                    Text = "DECRYPT",
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                    FlatStyle = FlatStyle.Flat
                };

                decryptCol.DefaultCellStyle.BackColor = Color.Green;
                decryptCol.DefaultCellStyle.ForeColor = Color.White;
                decryptCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add(decryptCol);
            }

            // ----- DELETE BUTTON (red) -----
            const string deleteColName = "DeleteButton";
            if (!dataGridView1.Columns.Contains(deleteColName))
            {
                DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn
                {
                    Name = deleteColName,
                    HeaderText = "Delete",
                    Text = "DELETE",
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                    FlatStyle = FlatStyle.Flat
                };

                deleteCol.DefaultCellStyle.BackColor = Color.Firebrick;
                deleteCol.DefaultCellStyle.ForeColor = Color.White;
                deleteCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns.Add(deleteCol);
            }
        }

        // ---------------- BUTTON ACTIONS ----------------

        private void dataBankGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (colName == "DecryptButton")
                HandleDecrypt(row);

            else if (colName == "DeleteButton")
                HandleDelete(row);
        }

        // ---------------- DECRYPT ----------------

        private void HandleDecrypt(DataGridViewRow row)
        {
            string cipherText = Convert.ToString(row.Cells["CipherText"].Value);

            string key = Convert.ToString(row.Cells["SecretKey"].Value);
            if (string.IsNullOrWhiteSpace(key) || key == "Secret Key")
                key = DefaultKey;

            try
            {
                string plainText = DecryptText(cipherText, key);

                row.Cells["CipherText"].Value = plainText;
                row.DefaultCellStyle.BackColor = Color.Beige;
            }
            catch
            {
                MessageBox.Show("Cannot decrypt text. Wrong key or corrupted data.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ---------------- DELETE ----------------

        private void HandleDelete(DataGridViewRow row)
        {
            int id = Convert.ToInt32(row.Cells["Id"].Value);

            var confirm = MessageBox.Show("Delete this item?",
                                          "Confirm",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM UserCipherData WHERE Id = @Id", conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                dataGridView1.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------- PLACEHOLDER ----------------

        private void dataBankGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "SecretKey") return;

            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Secret Key")
            {
                cell.Value = "";
                cell.Style.ForeColor = Color.Black;
            }
        }

        private void dataBankGrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "SecretKey") return;

            var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (string.IsNullOrWhiteSpace(cell.Value.ToString()))
            {
                cell.Value = "Secret Key";
                cell.Style.ForeColor = Color.Gray;
            }
        }

        // ---------------- CRYPTO ----------------

        private byte[] GetKeyBytes(string key)
        {
            using (var sha = SHA256.Create())
                return sha.ComputeHash(Encoding.UTF8.GetBytes(key));
        }

        private string DecryptText(string cipherText, string key)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherText);
            byte[] keyBytes = GetKeyBytes(key);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;

                byte[] iv = new byte[16];
                byte[] cipherBytes = new byte[fullCipher.Length - 16];

                Array.Copy(fullCipher, iv, 16);
                Array.Copy(fullCipher, 16, cipherBytes, 0, cipherBytes.Length);

                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(cipherBytes))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                    return sr.ReadToEnd();
            }
        }

        // ---------------- BACK BUTTON ----------------

        private void backButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            encryption enc = new encryption();
            enc.Show();
            this.Hide();
        }
    }
}
