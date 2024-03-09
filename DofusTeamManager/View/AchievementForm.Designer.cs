namespace DofusTeamManager.View
{
    partial class AchievementForm
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
            this.fastRunCheckBox = new System.Windows.Forms.CheckBox();
            this.achievementLabel = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servorComboBox
            // 
            this.servorComboBox.FormattingEnabled = true;
            this.servorComboBox.Location = new System.Drawing.Point(2, 0);
            this.servorComboBox.Name = "servorComboBox";
            this.servorComboBox.Size = new System.Drawing.Size(121, 21);
            this.servorComboBox.TabIndex = 0;
            this.servorComboBox.SelectedIndexChanged += new System.EventHandler(this.OnServorChanged);
            // 
            // fastRunCheckBox
            // 
            this.fastRunCheckBox.AutoSize = true;
            this.fastRunCheckBox.Checked = true;
            this.fastRunCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fastRunCheckBox.Location = new System.Drawing.Point(130, 3);
            this.fastRunCheckBox.Name = "fastRunCheckBox";
            this.fastRunCheckBox.Size = new System.Drawing.Size(100, 17);
            this.fastRunCheckBox.TabIndex = 1;
            this.fastRunCheckBox.Text = "Parcours rapide";
            this.fastRunCheckBox.UseVisualStyleBackColor = true;
            this.fastRunCheckBox.CheckedChanged += new System.EventHandler(this.OnFastRunCheckBoxChanged);
            // 
            // achievementLabel
            // 
            this.achievementLabel.AutoSize = true;
            this.achievementLabel.Location = new System.Drawing.Point(12, 24);
            this.achievementLabel.Name = "achievementLabel";
            this.achievementLabel.Size = new System.Drawing.Size(35, 13);
            this.achievementLabel.TabIndex = 2;
            this.achievementLabel.Text = "label1";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(2, 40);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Réussi !";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.ClickedOnDoneButton);
            // 
            // AchievementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.achievementLabel);
            this.Controls.Add(this.fastRunCheckBox);
            this.Controls.Add(this.servorComboBox);
            this.Name = "AchievementForm";
            this.Text = "AchievementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox servorComboBox;
        private System.Windows.Forms.CheckBox fastRunCheckBox;
        private System.Windows.Forms.Label achievementLabel;
        private System.Windows.Forms.Button doneButton;
    }
}