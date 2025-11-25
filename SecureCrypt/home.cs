using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureCrypt
{
    public partial class home : Form
    {
        private string _username;

        public home(string username)
        {
            InitializeComponent();
            _username = username;

            // 👇 Show it on a label
            welcomeLabel.Text = $"Welcome, {_username}";
        }

        private void encrpytNavButton_Click(object sender, EventArgs e)
        {
            encryption form = new encryption();   
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBankDatabase form = new dataBankDatabase();
            form.Show();
            this.Hide();
        }

        private void passStrengthNavButton_Click(object sender, EventArgs e)
        {
            passwordStrength form = new passwordStrength();
            form.Show();
            this.Hide();
        }
    }
}
