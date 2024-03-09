namespace DofusTeamManager.View
{
    partial class AddCharacterForm
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
            this.servorLabel = new System.Windows.Forms.Label();
            this.servorComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.accountComboBox = new System.Windows.Forms.ComboBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servorLabel
            // 
            this.servorLabel.AutoSize = true;
            this.servorLabel.Location = new System.Drawing.Point(12, 12);
            this.servorLabel.Name = "servorLabel";
            this.servorLabel.Size = new System.Drawing.Size(44, 13);
            this.servorLabel.TabIndex = 0;
            this.servorLabel.Text = "Serveur";
            // 
            // servorComboBox
            // 
            this.servorComboBox.FormattingEnabled = true;
            this.servorComboBox.Location = new System.Drawing.Point(114, 4);
            this.servorComboBox.Name = "servorComboBox";
            this.servorComboBox.Size = new System.Drawing.Size(149, 21);
            this.servorComboBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nom";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(114, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(149, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(11, 75);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(43, 13);
            this.accountLabel.TabIndex = 4;
            this.accountLabel.Text = "Compte";
            // 
            // accountComboBox
            // 
            this.accountComboBox.FormattingEnabled = true;
            this.accountComboBox.Location = new System.Drawing.Point(114, 72);
            this.accountComboBox.Name = "accountComboBox";
            this.accountComboBox.Size = new System.Drawing.Size(149, 21);
            this.accountComboBox.TabIndex = 5;
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(12, 110);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(38, 13);
            this.raceLabel.TabIndex = 8;
            this.raceLabel.Text = "Classe";
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(114, 107);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(149, 21);
            this.raceComboBox.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 139);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(168, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Ajouter ce personnage! ";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.ClickedOnSubmitButton);
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 174);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.raceComboBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.accountComboBox);
            this.Controls.Add(this.accountLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.servorComboBox);
            this.Controls.Add(this.servorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddCharacterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ajouter un personnage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label servorLabel;
        private System.Windows.Forms.ComboBox servorComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.ComboBox accountComboBox;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Button submitButton;
    }
}