namespace SecureCrypt
{
    partial class passwordStrength
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.strengthBar = new System.Windows.Forms.ProgressBar();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDigit = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(277, 124);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(516, 62);
            this.txtPassword.TabIndex = 0;
            // 
            // strengthBar
            // 
            this.strengthBar.Location = new System.Drawing.Point(277, 192);
            this.strengthBar.Name = "strengthBar";
            this.strengthBar.Size = new System.Drawing.Size(516, 27);
            this.strengthBar.TabIndex = 1;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(272, 233);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(68, 25);
            this.lblStrength.TabIndex = 2;
            this.lblStrength.Text = "Weak";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLength.Location = new System.Drawing.Point(273, 303);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(207, 21);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "• At least 8 characters";
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDigit.Location = new System.Drawing.Point(273, 445);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(222, 21);
            this.lblDigit.TabIndex = 4;
            this.lblDigit.Text = "• At least 1 number (0-9)";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLower.Location = new System.Drawing.Point(273, 399);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(254, 21);
            this.lblLower.TabIndex = 5;
            this.lblLower.Text = "• At least 1 lowercase letter";
            this.lblLower.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUpper.Location = new System.Drawing.Point(273, 351);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(256, 21);
            this.lblUpper.TabIndex = 6;
            this.lblUpper.Text = "• At least 1 uppercase letter";
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.lblSpecial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecial.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblSpecial.Location = new System.Drawing.Point(273, 491);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(304, 21);
            this.lblSpecial.TabIndex = 7;
            this.lblSpecial.Text = "• At least 1 special symbol (!,@,#)";
            // 
            // passwordStrength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1097, 759);
            this.Controls.Add(this.lblSpecial);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblDigit);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.strengthBar);
            this.Controls.Add(this.txtPassword);
            this.Name = "passwordStrength";
            this.Text = "passwordStrength";
            this.Load += new System.EventHandler(this.passwordStrength_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ProgressBar strengthBar;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblSpecial;
    }
}