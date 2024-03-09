using DofusTeamManager.Data;
using DofusTeamManager.Model;
using DofusTeamManager.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DofusTeamManager.View
{
    public partial class AchievementForm : Form
    {
        private bool FastRun = true;
        private Party Party;
        private Servor.Servors SelectedServor;
        private int StepIndex;
        private List<string> StepsToDo;
        private List<CheckBox> CharacterCheckBoxes;
        private List<ComboBox> CharacterComboBoxes;

        public AchievementForm()
        {
            Logger.SaveTitle("AchievementForm");
            InitializeComponent();
            WidgetTool.FillComboBoxWithList(servorComboBox, Servor.GetAll());
            SelectedServor = Servor.GetFromString(servorComboBox.SelectedItem.ToString());
            Party = new Party(SelectedServor);
            LoadAchievements();
            UpdateDisplay();
        }

        private void ReloadParty()
        {
            Party = new Party(SelectedServor);
            UpdateDisplay();
        }

        private string GetCurrentAchivement()
        {
            return StepsToDo[StepIndex];
        }

        private void OnCharacterCheckBoxChanged(CheckBox checkBox, EventArgs e)
        {
            int index = CharacterCheckBoxes.IndexOf(checkBox);
            Party.Characters[index].HasAlreadyDone(GetCurrentAchivement());
        }

        private void UpdateDisplay()
        {
            achievementLabel.Text = GetCurrentAchivement();
            CharacterCheckBoxes = new List<CheckBox>();
            CharacterComboBoxes = new List<ComboBox>();
            for(int i = 0; i < Party.Characters.Count; i++)
            {
                CheckBox checkBox = new CheckBox
                {
                    Text = Party.Characters[i].Name,
                    AutoSize = true,
                    Location = new System.Drawing.Point(10, 70 + 20 * i)
                };
                if (!Party.Characters[i].ShouldDoAchievement(GetCurrentAchivement()))
                {
                    checkBox.Checked = true;
                    checkBox.Enabled = false;
                }
                else checkBox.CheckedChanged += (sender, e) => OnCharacterCheckBoxChanged((CheckBox)sender, e);
                Controls.Add(checkBox);
                CharacterCheckBoxes.Add(checkBox);

                ComboBox comboBox = new ComboBox()
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(100, 66 + 20 * i)
                };
                WidgetTool.FillComboBoxWithList(comboBox, Party.GetCandidates(Party.Characters[i]));
                Controls.Add(comboBox);
                CharacterComboBoxes.Add(comboBox);
            }
        }

        private void LoadAchievements()
        {
            StepIndex = 0;
            StepsToDo = Party.GetStepsToDo(GetRun());
            achievementLabel.Text = GetCurrentAchivement();
        }

        private List<string> GetRun()
        {
            string filePath = FastRun ? "Data/Parcours rapide.txt" : "Data/Parcours.txt";
            return FileManager.GetFileLines(filePath);
        }

        private void OnServorChanged(object sender, EventArgs e)
        {
            if (StepsToDo != null)
            {
                SelectedServor = Servor.GetFromString(servorComboBox.SelectedItem.ToString());
                ReloadParty();
                LoadAchievements();
            }
        }

        private void OnFastRunCheckBoxChanged(object sender, EventArgs e)
        {
            FastRun = fastRunCheckBox.Checked;
            if (StepsToDo != null) LoadAchievements();
        }

        private void ClickedOnDoneButton(object sender, EventArgs e)
        {
            Party.Performed(GetCurrentAchivement());
            ++StepIndex;
            UpdateDisplay();
        }
    }
}
