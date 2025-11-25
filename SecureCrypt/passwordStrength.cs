using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SecureCrypt
{
    public partial class passwordStrength : Form
    {
        public passwordStrength()
        {
            InitializeComponent();

            // hide password characters
            txtPassword.UseSystemPasswordChar = true;

            // realtime updates
            txtPassword.TextChanged += txtPassword_TextChanged;

            // initialize UI
            UpdatePasswordStrength();
        }

        private void passwordStrength_Load(object sender, EventArgs e)
        {
            UpdatePasswordStrength();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordStrength();
        }

        // ---------- MAIN LOGIC ----------

        private void UpdatePasswordStrength()
        {
            string pwd = txtPassword.Text ?? string.Empty;

            bool hasLength = pwd.Length >= 8;
            bool hasUpper = pwd.Any(char.IsUpper);
            bool hasLower = pwd.Any(char.IsLower);
            bool hasDigit = pwd.Any(char.IsDigit);
            bool hasSpecial = pwd.Any(ch => !char.IsLetterOrDigit(ch));

            // update checklist labels
            UpdateCriteriaLabel(lblLength, hasLength, "At least 8 characters");
            UpdateCriteriaLabel(lblUpper, hasUpper, "At least 1 uppercase letter");
            UpdateCriteriaLabel(lblLower, hasLower, "At least 1 lowercase letter");
            UpdateCriteriaLabel(lblDigit, hasDigit, "At least 1 number (0-9)");
            UpdateCriteriaLabel(lblSpecial, hasSpecial, "At least 1 special symbol (!,@,#,...)");

            // calculate score
            int score = 0;
            if (hasLength) score += 20;
            if (hasUpper) score += 20;
            if (hasLower) score += 20;
            if (hasDigit) score += 20;
            if (hasSpecial) score += 20;

            if (score < 0) score = 0;
            if (score > 100) score = 100;

            strengthBar.Value = score;

            // strength text + color
            if (score <= 40)
            {
                lblStrength.Text = "Weak";
                lblStrength.ForeColor = Color.Red;
            }
            else if (score <= 80)
            {
                lblStrength.Text = "Medium";
                lblStrength.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblStrength.Text = "Strong";
                lblStrength.ForeColor = Color.Green;
            }
        }

        private void UpdateCriteriaLabel(Label label, bool ok, string text)
        {
            if (ok)
            {
                label.Text = "✔ " + text;
                label.BackColor = Color.GreenYellow;
                label.ForeColor = Color.DarkGreen;
            }
            else
            {
                label.Text = "• " + text;
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.DimGray;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passwordStrength_Load_1(object sender, EventArgs e)
        {

        }
    }
}
