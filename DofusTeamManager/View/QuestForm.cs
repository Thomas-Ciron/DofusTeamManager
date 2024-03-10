using DofusTeamManager.Data;
using DofusTeamManager.Model;
using DofusTeamManager.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DofusTeamManager.View
{
    public partial class QuestForm : Form
    {
        private Party Party;
        private List<Label> CharacterLabels;
        public QuestForm()
        {
            Logger.SaveTitle("QuestForm");
            InitializeComponent();
            WidgetTool.FillComboBoxWithList(servorComboBox, Servor.GetAll());
            WidgetTool.FillComboBoxWithFile(achievementComboBox, "Data/Achievements.csv");
            DisplayParty();
        }

        private string GetCurrentAchievement()
        {
            return achievementComboBox.SelectedItem.ToString();
        }

        public void DisplayParty()
        {
            Party = new Party(
                Servor.GetFromString(servorComboBox.SelectedItem.ToString()),
                GetCurrentAchievement());
            CharacterLabels = new List<Label>();
            for(int i = 0; i < Party.Characters.Count; i++)
            {
                Label label = new Label
                {
                    Text = Party.Characters[i].Name,
                    Location = new System.Drawing.Point(10, 50 + 20 * i),
                    AutoSize = true
                };
                CharacterLabels.Add(label);
                Controls.Add(label);
            }
        }

        private void OnServorChanged(object sender, EventArgs e)
        {
            if (Party != null) DisplayParty();
        }

        private void ClickedOnSubmitButton(object sender, EventArgs e)
        {
            Party.Performed(GetCurrentAchievement());
        }

        private void OnAchievementChanged(object sender, EventArgs e)
        {
            if (Party != null) DisplayParty();
        }
    }
}
