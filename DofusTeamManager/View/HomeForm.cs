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
        }

        private void ClickedOnAddCharacter(object sender, EventArgs e)
        {
            AddCharacterForm addCharacterform = new AddCharacterForm();
            addCharacterform.ShowDialog();
        }
    }
}
