namespace DofusTeamManager.View
{
    partial class QuestForm
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
            this.servorComboBox = new System.Windows.Forms.ComboBox();
            this.achievementComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servorComboBox
            // 
            this.servorComboBox.FormattingEnabled = true;
            this.servorComboBox.Location = new System.Drawing.Point(13, 13);
            this.servorComboBox.Name = "servorComboBox";
            this.servorComboBox.Size = new System.Drawing.Size(121, 21);
            this.servorComboBox.TabIndex = 0;
            this.servorComboBox.SelectedIndexChanged += new System.EventHandler(this.OnServorChanged);
            // 
            // achievementComboBox
            // 
            this.achievementComboBox.FormattingEnabled = true;
            this.achievementComboBox.Location = new System.Drawing.Point(140, 13);
            this.achievementComboBox.Name = "achievementComboBox";
            this.achievementComboBox.Size = new System.Drawing.Size(391, 21);
            this.achievementComboBox.TabIndex = 1;
            this.achievementComboBox.SelectedIndexChanged += new System.EventHandler(this.OnAchievementChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(226, 73);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Réussi !";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.ClickedOnSubmitButton);
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.achievementComboBox);
            this.Controls.Add(this.servorComboBox);
            this.Name = "QuestForm";
            this.Text = "QuestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox servorComboBox;
        private System.Windows.Forms.ComboBox achievementComboBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}