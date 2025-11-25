using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SecureCrypt
{
    public partial class Form2 : Form
    {
        private readonly string _connectionString =
            @"Data Source=SHOWRAB_LAPTOP\sqlexpress;Initial Catalog=SecureCrypt;Integrated Security=True;Encrypt=False;";

        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = signin;
        }

        private void signupNavigation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            // adjust names to your actual TextBoxes
            string emailInput = signInEmail.Text.Trim();
            string passwordInput = SignInPass.Text;

            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(passwordInput))
            {
               
                CustomMessageBox.ShowMessage("Validation Error", "Please enter both email and password for Sign In.");
                return;
            }

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT Password FROM userinfo WHERE Email = @Email", con))
                {
                    cmd.Parameters.AddWithValue("@Email", emailInput);

                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                     
                        CustomMessageBox.ShowMessage("Login Failed", "No Email registered.");

                        return;
                    }

                    string storedHash = Convert.ToString(result);

                    // Hash the password the user typed and compare with stored hash
                    string inputHash = PasswordHelper.HashPassword(passwordInput);

                    if (storedHash == inputHash)
                    {
                        // 🔴 Save the logged-in user's email for the rest of the app
                        SessionData.CurrentUserEmail = emailInput;   // <--- THIS IS THE IMPORTANT LINE

                        // Derive a nice display name
                        string userName = emailInput.Split('@')[0];

                        // Go to home page
                        home homeForm = new home(userName);
                        homeForm.Show();
                        this.Hide();

                        CustomMessageBox.ShowMessage("Login Successful", $"Welcome {userName}!");
                    }
                    else
                    {
                        CustomMessageBox.ShowMessage("Wrong password.", "Login Failed");
                    }
                }
            }
        }
    }
}
