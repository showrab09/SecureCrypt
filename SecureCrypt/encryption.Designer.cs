namespace SecureCrypt
{
    partial class encryption
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
            this.components = new System.ComponentModel.Container();
            this.encryptInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.encryptOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptSecretKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.encryptSecretKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptSecretKey = new System.Windows.Forms.TextBox();
            this.decryptSecretKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DecryptOutput = new System.Windows.Forms.TextBox();
            this.decryptInput = new System.Windows.Forms.TextBox();
            this.dataBankButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataBankButtonNavigation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptInput
            // 
            this.encryptInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptInput.Location = new System.Drawing.Point(101, 154);
            this.encryptInput.Multiline = true;
            this.encryptInput.Name = "encryptInput";
            this.encryptInput.Size = new System.Drawing.Size(772, 323);
            this.encryptInput.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // encryptOutput
            // 
            this.encryptOutput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptOutput.Location = new System.Drawing.Point(101, 613);
            this.encryptOutput.Multiline = true;
            this.encryptOutput.Name = "encryptOutput";
            this.encryptOutput.Size = new System.Drawing.Size(772, 354);
            this.encryptOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter any text to be Encrypted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Output";
            // 
            // encryptSecretKeyCheckBox
            // 
            this.encryptSecretKeyCheckBox.AutoSize = true;
            this.encryptSecretKeyCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptSecretKeyCheckBox.Location = new System.Drawing.Point(101, 485);
            this.encryptSecretKeyCheckBox.Name = "encryptSecretKeyCheckBox";
            this.encryptSecretKeyCheckBox.Size = new System.Drawing.Size(276, 28);
            this.encryptSecretKeyCheckBox.TabIndex = 1;
            this.encryptSecretKeyCheckBox.Text = "Encrypt with a custom secret key";
            this.encryptSecretKeyCheckBox.UseVisualStyleBackColor = true;
            this.encryptSecretKeyCheckBox.CheckedChanged += new System.EventHandler(this.encryptSecretKeyCheckBox_CheckedChanged);
            // 
            // encryptSecretKey
            // 
            this.encryptSecretKey.Enabled = false;
            this.encryptSecretKey.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptSecretKey.Location = new System.Drawing.Point(625, 485);
            this.encryptSecretKey.Multiline = true;
            this.encryptSecretKey.Name = "encryptSecretKey";
            this.encryptSecretKey.Size = new System.Drawing.Size(248, 48);
            this.encryptSecretKey.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Secret Key";
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.encryptButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.Location = new System.Drawing.Point(625, 553);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(248, 48);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "ENCRYPT";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.ForestGreen;
            this.decryptButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.Location = new System.Drawing.Point(1484, 553);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(248, 48);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "DECRYPT";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1321, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter Secret Key";
            // 
            // decryptSecretKey
            // 
            this.decryptSecretKey.Enabled = false;
            this.decryptSecretKey.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptSecretKey.Location = new System.Drawing.Point(1484, 485);
            this.decryptSecretKey.Multiline = true;
            this.decryptSecretKey.Name = "decryptSecretKey";
            this.decryptSecretKey.Size = new System.Drawing.Size(248, 48);
            this.decryptSecretKey.TabIndex = 8;
            // 
            // decryptSecretKeyCheckBox
            // 
            this.decryptSecretKeyCheckBox.AutoSize = true;
            this.decryptSecretKeyCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptSecretKeyCheckBox.Location = new System.Drawing.Point(960, 485);
            this.decryptSecretKeyCheckBox.Name = "decryptSecretKeyCheckBox";
            this.decryptSecretKeyCheckBox.Size = new System.Drawing.Size(277, 28);
            this.decryptSecretKeyCheckBox.TabIndex = 7;
            this.decryptSecretKeyCheckBox.Text = "Decrypt with a custom secret key";
            this.decryptSecretKeyCheckBox.UseVisualStyleBackColor = true;
            this.decryptSecretKeyCheckBox.CheckedChanged += new System.EventHandler(this.decryptSecretKeyCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(956, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Decrypted Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(956, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter any text to be Decrypted";
            // 
            // DecryptOutput
            // 
            this.DecryptOutput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptOutput.Location = new System.Drawing.Point(960, 613);
            this.DecryptOutput.Multiline = true;
            this.DecryptOutput.Name = "DecryptOutput";
            this.DecryptOutput.Size = new System.Drawing.Size(772, 354);
            this.DecryptOutput.TabIndex = 10;
            // 
            // decryptInput
            // 
            this.decryptInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptInput.Location = new System.Drawing.Point(960, 154);
            this.decryptInput.Multiline = true;
            this.decryptInput.Name = "decryptInput";
            this.decryptInput.Size = new System.Drawing.Size(772, 323);
            this.decryptInput.TabIndex = 6;
            // 
            // dataBankButton
            // 
            this.dataBankButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.dataBankButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBankButton.Location = new System.Drawing.Point(578, 993);
            this.dataBankButton.Name = "dataBankButton";
            this.dataBankButton.Size = new System.Drawing.Size(295, 48);
            this.dataBankButton.TabIndex = 5;
            this.dataBankButton.Text = "Store In Data Bank";
            this.dataBankButton.UseVisualStyleBackColor = false;
            this.dataBankButton.Click += new System.EventHandler(this.dataBankButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Salmon;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel1.Location = new System.Drawing.Point(21, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 43);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ScureCrypt";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataBankButtonNavigation
            // 
            this.dataBankButtonNavigation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dataBankButtonNavigation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBankButtonNavigation.Location = new System.Drawing.Point(1484, 36);
            this.dataBankButtonNavigation.Name = "dataBankButtonNavigation";
            this.dataBankButtonNavigation.Size = new System.Drawing.Size(248, 48);
            this.dataBankButtonNavigation.TabIndex = 11;
            this.dataBankButtonNavigation.Text = "DATA BANK";
            this.dataBankButtonNavigation.UseVisualStyleBackColor = false;
            this.dataBankButtonNavigation.Click += new System.EventHandler(this.button1_Click);
            // 
            // encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1753, 1097);
            this.Controls.Add(this.dataBankButtonNavigation);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataBankButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptSecretKey);
            this.Controls.Add(this.decryptSecretKeyCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DecryptOutput);
            this.Controls.Add(this.decryptInput);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptSecretKey);
            this.Controls.Add(this.encryptSecretKeyCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptOutput);
            this.Controls.Add(this.encryptInput);
            this.Name = "encryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encryptInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox encryptOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox encryptSecretKeyCheckBox;
        private System.Windows.Forms.TextBox encryptSecretKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptSecretKey;
        private System.Windows.Forms.CheckBox decryptSecretKeyCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DecryptOutput;
        private System.Windows.Forms.TextBox decryptInput;
        private System.Windows.Forms.Button dataBankButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button dataBankButtonNavigation;
    }
}