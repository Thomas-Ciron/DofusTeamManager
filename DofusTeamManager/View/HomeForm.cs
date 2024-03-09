using DofusTeamManager.View;
using System;
using System.Windows.Forms;

namespace DofusTeamManager
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            AdaptFormToUserScreen();
            LoadForm(new AchievementForm());
        }

        public void LoadForm(Form form)
        {
            mainPanel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void AdaptFormToUserScreen()
        {
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height - 40;
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip.Dock = DockStyle.Top;
            mainPanel.Dock = DockStyle.Fill;
        }

        private void ClickedOnAddCharacter(object sender, EventArgs e)
        {
            AddCharacterForm addCharacterform = new AddCharacterForm();
            addCharacterform.ShowDialog();
        }
    }
}
