using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newer_Cutscene_Editor
{
    public partial class AddCommand : Form
    {
        public AddCommand()
        {
            InitializeComponent();
        }

        public uint commandID;

        private void AddCommand_Load(object sender, EventArgs e)
        {
            commandComboBox.SelectedIndex = 0;
            okButton.Select();
        }

        private void commandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            okButton.Select();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            commandID = (uint)commandComboBox.SelectedIndex + 1;
            this.DialogResult = DialogResult.OK;
        }
    }
}
