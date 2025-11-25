using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;   // ✅ keep this
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validate the inputs first
            if (!ValidateInputs())
                return;

            string connString = @"Data Source=SHOWRAB_LAPTOP\sqlexpress;
                          Initial Catalog=SecureCrypt;
                          Integrated Security=True;
                          Encrypt=False;";

            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                // 2. Check if email already exists
                using (SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM userinfo WHERE Email = @Email", con))
                {
                    checkCmd.Parameters.AddWithValue("@Email", email.Text.Trim());

                    int existing = (int)checkCmd.ExecuteScalar();
                    if (existing > 0)
                    {
                        CustomMessageBox.ShowMessage("Registration Failed", "Email already registered.");
                        return; // stop here, do NOT insert
                    }
                }

                // 3. Hash the password before saving
                string rawPassword = password.Text.Trim();
                string hashedPassword = PasswordHelper.HashPassword(rawPassword);

                // 4. Insert new user (Id is identity, so not included)
                using (SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO userinfo (Name, Email, Password) VALUES (@Name, @Email, @Password)", con))
                {
                    insertCmd.Parameters.AddWithValue("@Name", name.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Email", email.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@Password", hashedPassword);

                    insertCmd.ExecuteNonQuery();
                }
            }

            // 5. Show success message and redirect to sign-in form
            Form2 signInForm = new Form2();   // Sign-in form
            signInForm.Show();
            this.Hide();
            CustomMessageBox.ShowMessage("Success", "Registration successful! Please sign in.");
        }

        private bool ValidateInputs()
        {
            // Trim inputs to remove extra spaces
            string fullName = name.Text.Trim();
            string emailAddress = email.Text.Trim();
            string pwd = password.Text.Trim();

            // ---------- Full Name ----------
            if (string.IsNullOrEmpty(fullName) || fullName == "Full Name")
            {
            
                CustomMessageBox.ShowMessage("Validation Error", "Full Name cannot be empty.");

                name.Focus();
                return false;
            }

            // ---------- Email ----------
            if (string.IsNullOrEmpty(emailAddress) || emailAddress == "Email")
            {
                CustomMessageBox.ShowMessage("Validation Error", "Email cannot be empty.");

                email.Focus();
                return false;
            }

            // Email format check (basic and clean)
            try
            {
                var emailCheck = new System.Net.Mail.MailAddress(emailAddress);
            }
            catch
            {
                CustomMessageBox.ShowMessage("Invalid Email", "Please enter a valid email address.");

                email.Focus();
                return false;
            }

            // ---------- Password ----------
            if (string.IsNullOrEmpty(pwd) || pwd == "Password")
            {

                CustomMessageBox.ShowMessage("Validation Error", "Password cannot be empty.");

                password.Focus();
                return false;
            }

            // Minimum length requirement
            if (pwd.Length < 6)
            {

                CustomMessageBox.ShowMessage("Weak Password", "Password must be at least 6 characters long.");

                password.Focus();
                return false;
            }

            return true; // All validations passed
        }

        private void signupNavigation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();   // open sign-in form
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
