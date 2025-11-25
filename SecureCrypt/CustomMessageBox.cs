using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecureCrypt
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string title, string message)
        {
            InitializeComponent();
            this.Text = title;

            // Set form size
            this.Size = new Size(400, 220);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Title Label
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 144, 255);
            lblTitle.AutoSize = false;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Height = 50;
            this.Controls.Add(lblTitle);

            // Message Label
            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblMessage.ForeColor = Color.Black;
            lblMessage.AutoSize = false;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Dock = DockStyle.Fill;
            this.Controls.Add(lblMessage);

            // OK Button
            Button btnOk = new Button();
            btnOk.Text = "OK";
            btnOk.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnOk.Size = new Size(100, 40);
            btnOk.BackColor = Color.FromArgb(30, 144, 255);
            btnOk.ForeColor = Color.White;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Location = new Point((this.ClientSize.Width - btnOk.Width) / 2, 140);
            btnOk.Click += (s, e) => this.Close();
            this.Controls.Add(btnOk);
        }

        public static void ShowMessage(string title, string message)
        {
            CustomMessageBox box = new CustomMessageBox(title, message);
            box.ShowDialog();
        }
    }
}
