using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Newer_Cutscene_Editor.NewerCutscene;

namespace Newer_Cutscene_Editor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        NewerCutscene thisCutscene = new NewerCutscene();
        List<byte> rawdata = new List<byte>();
        char[] rawstring;
        string originalPath = "";
        bool doneLoadingSceneParams = false;
        bool doneRewritingScene = true;
        bool doneLoadingParams = false;
        bool doneRewritingCommand = true;



        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisCutscene = new NewerCutscene();
            rawdata = new List<byte>();
            thisCutscene.sceneCount = 1;
            thisCutscene.scenes.Add(new NewerScene());
            LoadScenes(0);

            sceneGroupBox.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            generatePythonCodeToolStripMenuItem.Enabled = true;

            this.Text = "Newer Cutscene Editor - New File";
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                string output;
                dialog.Filter = "NewerSMBW Cutscene|*.cs|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    thisCutscene = new NewerCutscene();
                    output = dialog.FileName;
                    thisCutscene.loadFile(output, ref rawdata);
                    originalPath = output;
                    this.Text = "Newer Cutscene Editor - " + output.Split('\\')[output.Split('\\').Length - 1];
                    LoadScenes(0);

                    sceneGroupBox.Enabled = true;
                    saveToolStripMenuItem.Enabled = true;
                    saveAsToolStripMenuItem.Enabled = true;
                    generatePythonCodeToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(originalPath == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
                return;
            }
            List<byte> outputFile = new List<byte>();
            outputFile = thisCutscene.saveFile();
            using (FileStream outputBin = new FileStream(originalPath, FileMode.Create))
            {
                for (int i = 0; i < outputFile.ToArray().Length; i++)
                {
                    outputBin.WriteByte(outputFile[i]);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog textDialog;
            textDialog = new SaveFileDialog();
            textDialog.Filter = "NewerSMBW Cutscene|*.cs|All files (*.*)|*.*";
            if (textDialog.ShowDialog() == DialogResult.OK)
            {
                //Stream things to get the saved path
                System.IO.Stream fileStream = textDialog.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                string outputPath = ((FileStream)(sw.BaseStream)).Name;
                sw.Close();
                originalPath = outputPath;
                this.Text = "Newer Cutscene Editor - " + outputPath.Split('\\')[outputPath.Split('\\').Length - 1];

                //Save it
                saveToolStripMenuItem_Click(sender, e);
            }
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(generatePythonCode());
        }

        private void saveAsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string baseFile = "import struct\r\n\r\nclass Settings(object):\r\n	class Banner(object):\r\n		def __init__(self, name):\r\n			self.name = name\r\n			self.commands = []\r\n\r\n		def play_sound(self, delay, sound_id):\r\n			self.commands.append((1, delay, sound_id))\r\n\r\n		def play_looping_sound(self, handle_id, delay, sound_id):\r\n			self.commands.append((2, handle_id, delay, sound_id))\r\n\r\n		def stop_looping_sound(self, handle_id, delay, frame_count):\r\n			self.commands.append((3, handle_id, delay, frame_count))\r\n\r\n	def __init__(self, widescreen):\r\n		self.banners = []\r\n		self.widescreen = widescreen\r\n\r\n	def add_banner(self, name):\r\n		b = self.Banner(name)\r\n		self.banners.append(b)\r\n		return b\r\n	\r\n	def export(self):\r\n		header_size = 8\r\n\r\n		offset = header_size + (4 * len(self.banners))\r\n		banner_offsets = []\r\n		banner_data = []\r\n\r\n		for b in self.banners:\r\n			banner_offsets.append(offset)\r\n			\r\n			b_header1 = 'xxxx' # will be replaced later\r\n			b_header2 = struct.pack('>bxxxI', 1 if self.widescreen else 0, len(b.commands))\r\n			b_commands = []\r\n			b_commands_size = 0\r\n\r\n			for cmd in b.commands:\r\n				ctype = cmd[0]\r\n				if ctype == 1:\r\n					# Play Sound\r\n					b_commands.append(struct.pack('>III', 1, cmd[1], cmd[2]))\r\n					b_commands_size += 12\r\n				elif ctype == 2:\r\n					# Play Looping Sound\r\n					b_commands.append(struct.pack('>IIII', 2, cmd[1], cmd[2], cmd[3]))\r\n					b_commands_size += 16\r\n				elif ctype == 3:\r\n					# Stop Looping Sound\r\n					b_commands.append(struct.pack('>IIII', 3, cmd[1], cmd[2], cmd[3]))\r\n					b_commands_size += 16\r\n\r\n			offset += 12 + b_commands_size\r\n\r\n			b_data = [b_header1, b_header2]\r\n			b_data.extend(b_commands)\r\n			banner_data.append(b_data)\r\n\r\n		# now build a string table\r\n		str_tab = []\r\n\r\n		for b, b_data in zip(self.banners, banner_data):\r\n			b_data[0] = struct.pack('>I', offset)\r\n			offset += len(b.name) + 1\r\n			str_tab.append(b.name)\r\n			str_tab.append('\\0')\r\n	\r\n		# whatever\r\n		file_pieces = [\r\n			'NWcs',\r\n			struct.pack('>I', len(self.banners))\r\n			]\r\n\r\n		file_pieces.extend(map(lambda x: struct.pack('>I', x), banner_offsets))\r\n\r\n		for b_data in banner_data:\r\n			file_pieces.extend(b_data)\r\n		\r\n		file_pieces.extend(str_tab)\r\n\r\n		return ''.join(file_pieces)\r\n\r\n\r\n\r\n\r\n";
            string newCode = generatePythonCode();

            SaveFileDialog textDialog;
            textDialog = new SaveFileDialog();
            textDialog.Filter = "Python File|*.py|All files (*.*)|*.*";
            if (textDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream fileStream = textDialog.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                string outputPath = ((FileStream)(sw.BaseStream)).Name;
                sw.Close();

                File.WriteAllText(outputPath, baseFile + newCode);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Newer Cutscene Editor is a program which can edit and save NewerSMBW Cutscene files.\r\n\r\n"
                          + "Programmed by RedStoneMatt\r\n", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoadScenes(int selectedIndex)
        {
            sceneListBox.Items.Clear();

            for (int i = 0; i < thisCutscene.sceneCount; i++)
            {
                sceneListBox.Items.Add("Scene " + (i + 1) + ": " + thisCutscene.scenes[i].filename);
            }

            sceneListBox.SelectedIndex = selectedIndex;
        }

        public void LoadCommands(int selectedIndex)
        {
            if (doneRewritingScene)
            {
                doneLoadingSceneParams = false;

                commandListBox.Items.Clear();

                commandGroupBox.Text = "Commands - Scene " + (sceneListBox.SelectedIndex + 1);
                for (int i = 0; i < thisCutscene.scenes[sceneListBox.SelectedIndex].commandCount; i++)
                {
                    NewerCommand currentCommand = thisCutscene.scenes[sceneListBox.SelectedIndex].commands[i];
                    string[] commandName = {
                    "Play SFX " + currentCommand.param2 + " after " + currentCommand.param1 + " frames",
                    "Play Looping Sound " + currentCommand.param3 + " after " + currentCommand.param2 + " frames on handle " + currentCommand.param1,
                    "Stop Looping Sound after " + currentCommand.param2 + " frames on handle " + currentCommand.param1 + ", fading for " + currentCommand.param3 + " frames"
                    };
                    commandListBox.Items.Add(commandName[currentCommand.commandID - 1]);
                }
                widescreenCheckBox.Checked = Convert.ToBoolean(thisCutscene.scenes[sceneListBox.SelectedIndex].widescreenFlag);
                filenameTextBox.Text = thisCutscene.scenes[sceneListBox.SelectedIndex].filename;

                commandListBox.SelectedIndex = ((thisCutscene.scenes[sceneListBox.SelectedIndex].commandCount == 0) ? -1 : selectedIndex);

                doneLoadingSceneParams = true;
            }
        }

        public void LoadParams()
        {
            if (doneRewritingCommand)
            {
                doneLoadingParams = false;

                NewerCommand currentCommand = thisCutscene.scenes[sceneListBox.SelectedIndex].commands[commandListBox.SelectedIndex];

                param1NumUpDown.Value = currentCommand.param1;
                param2NumUpDown.Value = currentCommand.param2;
                param2NumUpDown.Visible = Convert.ToBoolean(currentCommand.commandID != 1);
                param3NumUpDown.Value = ((currentCommand.commandID == 1) ? currentCommand.param2 : currentCommand.param3);

                param1Label.Text = (currentCommand.commandID > 1) ? "Handle ID:" : "Delay:";
                param2Label.Text = (currentCommand.commandID > 1) ? "Delay:" : "";
                param3Label.Text = (currentCommand.commandID < 3) ? "Sound ID:" : "Fade Frame Count:";

                doneLoadingParams = true;
            }
        }

        private void sceneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCommands(0);
        }

        private void commandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParams();
        }

        private void paramNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (doneLoadingParams)
            {
                doneRewritingCommand = false;

                NewerCommand currentCommand = thisCutscene.scenes[sceneListBox.SelectedIndex].commands[commandListBox.SelectedIndex];
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands[commandListBox.SelectedIndex].param1 = (uint)param1NumUpDown.Value;
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands[commandListBox.SelectedIndex].param2 = (currentCommand.commandID == 1) ? (uint)param3NumUpDown.Value : (uint)param2NumUpDown.Value;
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands[commandListBox.SelectedIndex].param3 = (uint)param3NumUpDown.Value;

                string[] commandName = {
                "Play SFX " + currentCommand.param2 + " after " + currentCommand.param1 + " frames",
                "Play Looping Sound " + currentCommand.param3 + " after " + currentCommand.param2 + " frames on handle " + currentCommand.param1,
                "Stop Looping Sound after " + currentCommand.param2 + " frames on handle " + currentCommand.param1 + ", fading for " + currentCommand.param3 + " frames"
                };
                commandListBox.Items[commandListBox.SelectedIndex] = commandName[currentCommand.commandID - 1];

                doneRewritingCommand = true;
            }
        }

        private void sceneParam_Changed(object sender, EventArgs e)
        {
            if (doneLoadingSceneParams)
            {
                doneRewritingScene = false;

                thisCutscene.scenes[sceneListBox.SelectedIndex].filename = filenameTextBox.Text;
                thisCutscene.scenes[sceneListBox.SelectedIndex].widescreenFlag = Convert.ToByte(widescreenCheckBox.Checked);

                sceneListBox.Items[sceneListBox.SelectedIndex] = "Scene " + (sceneListBox.SelectedIndex + 1) + ": " + thisCutscene.scenes[sceneListBox.SelectedIndex].filename;

                doneRewritingScene = true;
            }
        }

        private void addSceneButton_Click(object sender, EventArgs e)
        {
            thisCutscene.scenes.Add(new NewerScene());
            thisCutscene.sceneCount++;
            LoadScenes((int)thisCutscene.sceneCount - 1);
        }

        private void removeSceneButton_Click(object sender, EventArgs e)
        {
            if (thisCutscene.scenes.Count > 1)
            {
                thisCutscene.scenes.RemoveAt(sceneListBox.SelectedIndex);
                thisCutscene.sceneCount--;
                LoadScenes(sceneListBox.SelectedIndex - 1);
            }
        }

        private void moveUpSceneButton_Click(object sender, EventArgs e)
        {
            if (sceneListBox.SelectedIndex > 0)
            {
                NewerScene sceneToMove = thisCutscene.scenes[sceneListBox.SelectedIndex];
                thisCutscene.scenes.RemoveAt(sceneListBox.SelectedIndex);
                thisCutscene.scenes.Insert(sceneListBox.SelectedIndex - 1, sceneToMove);
                LoadScenes(sceneListBox.SelectedIndex - 1);
            }
        }

        private void moveDownSceneButton_Click(object sender, EventArgs e)
        {
            if (sceneListBox.SelectedIndex < (thisCutscene.sceneCount - 1))
            {
                NewerScene sceneToMove = thisCutscene.scenes[sceneListBox.SelectedIndex];
                thisCutscene.scenes.RemoveAt(sceneListBox.SelectedIndex);
                thisCutscene.scenes.Insert(sceneListBox.SelectedIndex + 1, sceneToMove);
                LoadScenes(sceneListBox.SelectedIndex + 1);
            }
        }

        private void addCommandButton_Click(object sender, EventArgs e)
        {
            AddCommand a = new AddCommand();
            DialogResult dialogresult = a.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                a.Close();
                NewerCommand newCommand = new NewerCommand();
                newCommand.commandID = a.commandID;
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands.Add(newCommand);
                thisCutscene.scenes[sceneListBox.SelectedIndex].commandCount++;
                LoadCommands((int)thisCutscene.scenes[sceneListBox.SelectedIndex].commandCount - 1);
            }
        }

        private void removeCommandButton_Click(object sender, EventArgs e)
        {
            if (thisCutscene.scenes[sceneListBox.SelectedIndex].commands.Count > 0)
            {
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands.RemoveAt(commandListBox.SelectedIndex);
                thisCutscene.scenes[sceneListBox.SelectedIndex].commandCount--;
                LoadCommands(commandListBox.SelectedIndex - 1);
            }
        }

        private void moveUpCommandButton_Click(object sender, EventArgs e)
        {
            if (commandListBox.SelectedIndex > 0)
            {
                NewerCommand commandToMove = thisCutscene.scenes[sceneListBox.SelectedIndex].commands[commandListBox.SelectedIndex];
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands.RemoveAt(commandListBox.SelectedIndex);
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands.Insert(commandListBox.SelectedIndex - 1, commandToMove);
                LoadCommands(commandListBox.SelectedIndex - 1);
            }
        }

        private void moveDownCommandButton_Click(object sender, EventArgs e)
        {
            if (commandListBox.SelectedIndex < ((int)thisCutscene.scenes[sceneListBox.SelectedIndex].commandCount - 1))
            {
                NewerCommand commandToMove = thisCutscene.scenes[sceneListBox.SelectedIndex].commands[commandListBox.SelectedIndex];
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands.RemoveAt(commandListBox.SelectedIndex);
                thisCutscene.scenes[sceneListBox.SelectedIndex].commands.Insert(commandListBox.SelectedIndex + 1, commandToMove);
                LoadCommands(commandListBox.SelectedIndex + 1);
            }
        }

        private string generatePythonCode()
        {
            string code = "";
            code += "s = Settings(widescreen=" + ((thisCutscene.scenes[0].widescreenFlag == 1) ? "True" : "False") + ")\r\n\r\n";
            foreach (NewerScene thisScene in thisCutscene.scenes)
            {
                code += "b = s.add_banner('" + thisScene.filename + "')\r\n";
                foreach(NewerCommand thisCommand in thisScene.commands)
                {
                    switch(thisCommand.commandID)
                    {
                        case 1:
                            code += "b.play_sound(delay=" + thisCommand.param1 + ", sound_id=" + thisCommand.param2 + ")\r\n";
                            break;
                        case 2:
                            code += "b.play_looping_sound(handle_id=" + thisCommand.param1 + ", delay=" + thisCommand.param2 + ", sound_id=" + thisCommand.param3 + ")\r\n";
                            break;
                        case 3:
                            code += "b.stop_looping_sound(handle_id=" + thisCommand.param1 + ", delay=" + thisCommand.param2 + ", frame_count=" + thisCommand.param3 + ")\r\n";
                            break;
                    }
                }
            }
            code += "\r\n\r\ndata = s.export()\r\nopen('" + originalPath.Split('\\')[originalPath.Split('\\').Length - 1] + "', 'wb').write(data)";
            return code;
        }
    }
}
