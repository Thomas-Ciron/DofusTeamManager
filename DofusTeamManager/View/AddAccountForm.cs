using DofusTeamManager.Utils;
using System;
using System.Windows.Forms;

namespace DofusTeamManager.View
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void ClickedOnSubmitButton(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            bool isSubscribed = subscribedCheckBox.Checked;
            FileManager.AddContentToFile("Data/Accounts.csv",$"\n{name};{isSubscribed}");
            MessageBox.Show($"{name} a bien été ajouté à la liste des comptes !");
            Close();
        }
    }
}
