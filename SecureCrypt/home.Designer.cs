namespace SecureCrypt
{
    partial class home
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.encrpytNavButton = new System.Windows.Forms.Button();
            this.passStrengthNavButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(736, 43);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 23);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // encrpytNavButton
            // 
            this.encrpytNavButton.BackColor = System.Drawing.Color.DarkBlue;
            this.encrpytNavButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrpytNavButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encrpytNavButton.Location = new System.Drawing.Point(334, 209);
            this.encrpytNavButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encrpytNavButton.Name = "encrpytNavButton";
            this.encrpytNavButton.Size = new System.Drawing.Size(917, 154);
            this.encrpytNavButton.TabIndex = 6;
            this.encrpytNavButton.Text = "Encryption and Decryption";
            this.encrpytNavButton.UseVisualStyleBackColor = false;
            this.encrpytNavButton.Click += new System.EventHandler(this.encrpytNavButton_Click);
            // 
            // passStrengthNavButton
            // 
            this.passStrengthNavButton.BackColor = System.Drawing.Color.DarkBlue;
            this.passStrengthNavButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passStrengthNavButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passStrengthNavButton.Location = new System.Drawing.Point(334, 554);
            this.passStrengthNavButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passStrengthNavButton.Name = "passStrengthNavButton";
            this.passStrengthNavButton.Size = new System.Drawing.Size(917, 154);
            this.passStrengthNavButton.TabIndex = 8;
            this.passStrengthNavButton.Text = "Password Strength Checker";
            this.passStrengthNavButton.UseVisualStyleBackColor = false;
            this.passStrengthNavButton.Click += new System.EventHandler(this.passStrengthNavButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Salmon;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel1.Location = new System.Drawing.Point(30, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 43);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ScureCrypt";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(334, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(917, 154);
            this.button1.TabIndex = 10;
            this.button1.Text = "Data Bank";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1587, 1012);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passStrengthNavButton);
            this.Controls.Add(this.encrpytNavButton);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "home";
            this.Text = "home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button encrpytNavButton;
        private System.Windows.Forms.Button passStrengthNavButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}