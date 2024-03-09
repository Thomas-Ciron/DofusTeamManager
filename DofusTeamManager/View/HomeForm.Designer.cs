namespace DofusTeamManager
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip1";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // personnagesToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacterToolStripMenuItem});
            this.charactersToolStripMenuItem.Name = "personnagesToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.charactersToolStripMenuItem.Text = "Personnages";
            // 
            // ajouterUnPersonnageToolStripMenuItem
            // 
            this.addCharacterToolStripMenuItem.Name = "ajouterUnPersonnageToolStripMenuItem";
            this.addCharacterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addCharacterToolStripMenuItem.Text = "Ajouter un personnage";
            this.addCharacterToolStripMenuItem.Click += new System.EventHandler(this.ClickedOnAddCharacter);
            // 
            // HomeFome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HomeFome";
            this.Text = "Dofus Team Manager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCharacterToolStripMenuItem;
    }
}

