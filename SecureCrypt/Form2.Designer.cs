namespace SecureCrypt
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.SignInPass = new System.Windows.Forms.TextBox();
            this.signInEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signupNavigation = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.signin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signin.Location = new System.Drawing.Point(894, 466);
            this.signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(434, 89);
            this.signin.TabIndex = 12;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // SignInPass
            // 
            this.SignInPass.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInPass.Location = new System.Drawing.Point(894, 385);
            this.SignInPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignInPass.Multiline = true;
            this.SignInPass.Name = "SignInPass";
            this.SignInPass.PasswordChar = '*';
            this.SignInPass.Size = new System.Drawing.Size(434, 68);
            this.SignInPass.TabIndex = 11;
            // 
            // signInEmail
            // 
            this.signInEmail.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInEmail.Location = new System.Drawing.Point(894, 291);
            this.signInEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInEmail.Multiline = true;
            this.signInEmail.Name = "signInEmail";
            this.signInEmail.Size = new System.Drawing.Size(434, 68);
            this.signInEmail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(882, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 70);
            this.label1.TabIndex = 9;
            this.label1.Text = "SecureCrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(901, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Don\'t have a account?";
            // 
            // signupNavigation
            // 
            this.signupNavigation.AutoSize = true;
            this.signupNavigation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupNavigation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupNavigation.Location = new System.Drawing.Point(1096, 568);
            this.signupNavigation.Name = "signupNavigation";
            this.signupNavigation.Size = new System.Drawing.Size(86, 23);
            this.signupNavigation.TabIndex = 16;
            this.signupNavigation.TabStop = true;
            this.signupNavigation.Text = "Sign Up";
            this.signupNavigation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupNavigation_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(607, 46);
            this.label5.TabIndex = 17;
            this.label5.Text = "Secure all your personal data.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(501, 38);
            this.label6.TabIndex = 18;
            this.label6.Text = "Your personal Password Bank";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1606, 880);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signupNavigation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.SignInPass);
            this.Controls.Add(this.signInEmail);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.TextBox SignInPass;
        private System.Windows.Forms.TextBox signInEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel signupNavigation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}