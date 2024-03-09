using DofusTeamManager.Data;
using DofusTeamManager.Utils;
using System;
using System.Windows.Forms;
using static DofusTeamManager.Data.Race;
using static DofusTeamManager.Data.Servor;

namespace DofusTeamManager.View
{
    public partial class AddCharacterForm : Form
    {
        public AddCharacterForm()
        {
            InitializeComponent();
            WidgetTool.FillComboBoxWithList(servorComboBox, Servor.GetAll());
            WidgetTool.FillComboBoxWithList(accountComboBox, Account.GetAll());
            WidgetTool.FillComboBoxWithList(raceComboBox, Race.GetAll());
        }

        private void ClickedOnSubmitButton(object sender, EventArgs e)
        {
            Servors servor = Servor.GetFromString(servorComboBox.SelectedItem.ToString());
            Races race = Race.GetFromString(raceComboBox.SelectedItem.ToString());
            Account account = Account.GetFromString(accountComboBox.SelectedItem.ToString());
            string name = nameTextBox.Text;
            Character character = new Character(name, account, race, servor);
            character.Add();
            MessageBox.Show(name + " a bien été créé.");
            Close();
        }
    }
}
