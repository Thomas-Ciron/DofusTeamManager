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
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.activitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donjonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quêteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem,
            this.comptesToolStripMenuItem,
            this.activitésToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacterToolStripMenuItem});
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.charactersToolStripMenuItem.Text = "Personnages";
            // 
            // addCharacterToolStripMenuItem
            // 
            this.addCharacterToolStripMenuItem.Name = "addCharacterToolStripMenuItem";
            this.addCharacterToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.addCharacterToolStripMenuItem.Text = "Ajouter un personnage";
            this.addCharacterToolStripMenuItem.Click += new System.EventHandler(this.ClickedOnAddCharacter);
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnCompteToolStripMenuItem});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comptesToolStripMenuItem.Text = "Comptes";
            // 
            // ajouterUnCompteToolStripMenuItem
            // 
            this.ajouterUnCompteToolStripMenuItem.Name = "ajouterUnCompteToolStripMenuItem";
            this.ajouterUnCompteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ajouterUnCompteToolStripMenuItem.Text = "Ajouter un compte";
            this.ajouterUnCompteToolStripMenuItem.Click += new System.EventHandler(this.ClickedOnAddAccount);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 420);
            this.mainPanel.TabIndex = 1;
            // 
            // activitésToolStripMenuItem
            // 
            this.activitésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donjonToolStripMenuItem,
            this.quêteToolStripMenuItem});
            this.activitésToolStripMenuItem.Name = "activitésToolStripMenuItem";
            this.activitésToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.activitésToolStripMenuItem.Text = "Activités";
            // 
            // donjonToolStripMenuItem
            // 
            this.donjonToolStripMenuItem.Name = "donjonToolStripMenuItem";
            this.donjonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.donjonToolStripMenuItem.Text = "Donjon";
            // 
            // quêteToolStripMenuItem
            // 
            this.quêteToolStripMenuItem.Name = "quêteToolStripMenuItem";
            this.quêteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quêteToolStripMenuItem.Text = "Quête";
            this.quêteToolStripMenuItem.Click += new System.EventHandler(this.ClickedOnQuest);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
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
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donjonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quêteToolStripMenuItem;
    }
}

