namespace EncryptionClient
{
    partial class EncryptionForm
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
            this.encryptionTextField = new System.Windows.Forms.RichTextBox();
            this.encryptionButton = new System.Windows.Forms.Button();
            this.decryptionButton = new System.Windows.Forms.Button();
            this.selectProfileLabel = new System.Windows.Forms.Label();
            this.selectProfileComboBox = new System.Windows.Forms.ComboBox();
            this.createProfileButton = new System.Windows.Forms.Button();
            this.loadProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptionTextField
            // 
            this.encryptionTextField.Location = new System.Drawing.Point(8, 102);
            this.encryptionTextField.Name = "encryptionTextField";
            this.encryptionTextField.Size = new System.Drawing.Size(422, 228);
            this.encryptionTextField.TabIndex = 0;
            this.encryptionTextField.Text = "";
            // 
            // encryptionButton
            // 
            this.encryptionButton.Location = new System.Drawing.Point(8, 12);
            this.encryptionButton.Name = "encryptionButton";
            this.encryptionButton.Size = new System.Drawing.Size(75, 23);
            this.encryptionButton.TabIndex = 1;
            this.encryptionButton.Text = "Encrypt";
            this.encryptionButton.UseVisualStyleBackColor = true;
            this.encryptionButton.Click += new System.EventHandler(this.encryptionButton_Click);
            // 
            // decryptionButton
            // 
            this.decryptionButton.Location = new System.Drawing.Point(89, 12);
            this.decryptionButton.Name = "decryptionButton";
            this.decryptionButton.Size = new System.Drawing.Size(75, 23);
            this.decryptionButton.TabIndex = 2;
            this.decryptionButton.Text = "Decrypt";
            this.decryptionButton.UseVisualStyleBackColor = true;
            this.decryptionButton.Click += new System.EventHandler(this.decryptionButton_Click);
            // 
            // selectProfileLabel
            // 
            this.selectProfileLabel.AutoSize = true;
            this.selectProfileLabel.Location = new System.Drawing.Point(5, 47);
            this.selectProfileLabel.Name = "selectProfileLabel";
            this.selectProfileLabel.Size = new System.Drawing.Size(69, 13);
            this.selectProfileLabel.TabIndex = 3;
            this.selectProfileLabel.Text = "Select Profile";
            // 
            // selectProfileComboBox
            // 
            this.selectProfileComboBox.FormattingEnabled = true;
            this.selectProfileComboBox.Location = new System.Drawing.Point(8, 63);
            this.selectProfileComboBox.Name = "selectProfileComboBox";
            this.selectProfileComboBox.Size = new System.Drawing.Size(156, 21);
            this.selectProfileComboBox.TabIndex = 4;
            // 
            // createProfileButton
            // 
            this.createProfileButton.Location = new System.Drawing.Point(270, 12);
            this.createProfileButton.Name = "createProfileButton";
            this.createProfileButton.Size = new System.Drawing.Size(79, 23);
            this.createProfileButton.TabIndex = 5;
            this.createProfileButton.Text = "Create Profile";
            this.createProfileButton.UseVisualStyleBackColor = true;
            this.createProfileButton.Click += new System.EventHandler(this.createProfileButton_Click);
            // 
            // loadProfileButton
            // 
            this.loadProfileButton.Location = new System.Drawing.Point(355, 12);
            this.loadProfileButton.Name = "loadProfileButton";
            this.loadProfileButton.Size = new System.Drawing.Size(75, 23);
            this.loadProfileButton.TabIndex = 6;
            this.loadProfileButton.Text = "Load Profile";
            this.loadProfileButton.UseVisualStyleBackColor = true;
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 342);
            this.Controls.Add(this.loadProfileButton);
            this.Controls.Add(this.createProfileButton);
            this.Controls.Add(this.selectProfileComboBox);
            this.Controls.Add(this.selectProfileLabel);
            this.Controls.Add(this.decryptionButton);
            this.Controls.Add(this.encryptionButton);
            this.Controls.Add(this.encryptionTextField);
            this.Name = "EncryptionForm";
            this.Text = "Encryption Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox encryptionTextField;
        private System.Windows.Forms.Button encryptionButton;
        private System.Windows.Forms.Button decryptionButton;
        private System.Windows.Forms.Label selectProfileLabel;
        private System.Windows.Forms.ComboBox selectProfileComboBox;
        private System.Windows.Forms.Button createProfileButton;
        private System.Windows.Forms.Button loadProfileButton;
    }
}

