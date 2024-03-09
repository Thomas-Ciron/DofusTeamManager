using System.Collections.Generic;
using System.Windows.Forms;

namespace DofusTeamManager.Utils
{
    internal class WidgetTool
    {
        public static void FillComboBoxWithList(ComboBox comboBox, List<string> list)
        {
            comboBox.Items.Clear();
            if (list == null || list.Count == 0) return;
            foreach(string item in list) comboBox.Items.Add(item);
            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void FillComboBoxWithFile(ComboBox comboBox, string filePath)
        {
            FillComboBoxWithList(comboBox, FileManager.GetFileLines(filePath));
        }
    }
}
