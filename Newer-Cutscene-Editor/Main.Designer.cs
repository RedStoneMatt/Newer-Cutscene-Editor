namespace Newer_Cutscene_Editor
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePythonCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sceneListBox = new System.Windows.Forms.ListBox();
            this.sceneGroupBox = new System.Windows.Forms.GroupBox();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.moveDownSceneButton = new System.Windows.Forms.Button();
            this.removeSceneButton = new System.Windows.Forms.Button();
            this.moveUpSceneButton = new System.Windows.Forms.Button();
            this.widescreenCheckBox = new System.Windows.Forms.CheckBox();
            this.commandGroupBox = new System.Windows.Forms.GroupBox();
            this.moveDownCommandButton = new System.Windows.Forms.Button();
            this.param3Label = new System.Windows.Forms.Label();
            this.removeCommandButton = new System.Windows.Forms.Button();
            this.param2Label = new System.Windows.Forms.Label();
            this.moveUpCommandButton = new System.Windows.Forms.Button();
            this.param1Label = new System.Windows.Forms.Label();
            this.addCommandButton = new System.Windows.Forms.Button();
            this.param3NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.param2NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.param1NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.addSceneButton = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.sceneGroupBox.SuspendLayout();
            this.commandGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.param3NumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2NumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatePythonCodeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generatePythonCodeToolStripMenuItem
            // 
            this.generatePythonCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem1,
            this.copyToClipboardToolStripMenuItem});
            this.generatePythonCodeToolStripMenuItem.Enabled = false;
            this.generatePythonCodeToolStripMenuItem.Name = "generatePythonCodeToolStripMenuItem";
            this.generatePythonCodeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.generatePythonCodeToolStripMenuItem.Text = "Generate Python Code";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(295, 26);
            this.saveAsToolStripMenuItem1.Text = "Save As...";
            this.saveAsToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem1_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(295, 26);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sceneListBox
            // 
            this.sceneListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sceneListBox.FormattingEnabled = true;
            this.sceneListBox.HorizontalScrollbar = true;
            this.sceneListBox.ItemHeight = 16;
            this.sceneListBox.Location = new System.Drawing.Point(6, 21);
            this.sceneListBox.Name = "sceneListBox";
            this.sceneListBox.Size = new System.Drawing.Size(216, 340);
            this.sceneListBox.TabIndex = 1;
            this.sceneListBox.SelectedIndexChanged += new System.EventHandler(this.sceneListBox_SelectedIndexChanged);
            // 
            // sceneGroupBox
            // 
            this.sceneGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sceneGroupBox.Controls.Add(this.filenameLabel);
            this.sceneGroupBox.Controls.Add(this.filenameTextBox);
            this.sceneGroupBox.Controls.Add(this.moveDownSceneButton);
            this.sceneGroupBox.Controls.Add(this.removeSceneButton);
            this.sceneGroupBox.Controls.Add(this.moveUpSceneButton);
            this.sceneGroupBox.Controls.Add(this.widescreenCheckBox);
            this.sceneGroupBox.Controls.Add(this.commandGroupBox);
            this.sceneGroupBox.Controls.Add(this.addSceneButton);
            this.sceneGroupBox.Controls.Add(this.sceneListBox);
            this.sceneGroupBox.Enabled = false;
            this.sceneGroupBox.Location = new System.Drawing.Point(12, 31);
            this.sceneGroupBox.Name = "sceneGroupBox";
            this.sceneGroupBox.Size = new System.Drawing.Size(776, 460);
            this.sceneGroupBox.TabIndex = 2;
            this.sceneGroupBox.TabStop = false;
            this.sceneGroupBox.Text = "Scenes";
            // 
            // filenameLabel
            // 
            this.filenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(231, 431);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(69, 17);
            this.filenameLabel.TabIndex = 8;
            this.filenameLabel.Text = "Filename:";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.filenameTextBox.Location = new System.Drawing.Point(306, 429);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(333, 22);
            this.filenameTextBox.TabIndex = 9;
            this.filenameTextBox.TextChanged += new System.EventHandler(this.sceneParam_Changed);
            // 
            // moveDownSceneButton
            // 
            this.moveDownSceneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveDownSceneButton.Location = new System.Drawing.Point(117, 425);
            this.moveDownSceneButton.Name = "moveDownSceneButton";
            this.moveDownSceneButton.Size = new System.Drawing.Size(105, 26);
            this.moveDownSceneButton.TabIndex = 8;
            this.moveDownSceneButton.Text = "Move Down";
            this.moveDownSceneButton.UseVisualStyleBackColor = true;
            this.moveDownSceneButton.Click += new System.EventHandler(this.moveDownSceneButton_Click);
            // 
            // removeSceneButton
            // 
            this.removeSceneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeSceneButton.Location = new System.Drawing.Point(6, 396);
            this.removeSceneButton.Name = "removeSceneButton";
            this.removeSceneButton.Size = new System.Drawing.Size(216, 23);
            this.removeSceneButton.TabIndex = 6;
            this.removeSceneButton.Text = "Remove Scene";
            this.removeSceneButton.UseVisualStyleBackColor = true;
            this.removeSceneButton.Click += new System.EventHandler(this.removeSceneButton_Click);
            // 
            // moveUpSceneButton
            // 
            this.moveUpSceneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveUpSceneButton.Location = new System.Drawing.Point(6, 425);
            this.moveUpSceneButton.Name = "moveUpSceneButton";
            this.moveUpSceneButton.Size = new System.Drawing.Size(105, 26);
            this.moveUpSceneButton.TabIndex = 7;
            this.moveUpSceneButton.Text = "Move Up";
            this.moveUpSceneButton.UseVisualStyleBackColor = true;
            this.moveUpSceneButton.Click += new System.EventHandler(this.moveUpSceneButton_Click);
            // 
            // widescreenCheckBox
            // 
            this.widescreenCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widescreenCheckBox.AutoSize = true;
            this.widescreenCheckBox.Location = new System.Drawing.Point(645, 431);
            this.widescreenCheckBox.Name = "widescreenCheckBox";
            this.widescreenCheckBox.Size = new System.Drawing.Size(119, 21);
            this.widescreenCheckBox.TabIndex = 4;
            this.widescreenCheckBox.Text = "Is Widescreen";
            this.widescreenCheckBox.UseVisualStyleBackColor = true;
            this.widescreenCheckBox.CheckedChanged += new System.EventHandler(this.sceneParam_Changed);
            // 
            // commandGroupBox
            // 
            this.commandGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandGroupBox.Controls.Add(this.moveDownCommandButton);
            this.commandGroupBox.Controls.Add(this.param3Label);
            this.commandGroupBox.Controls.Add(this.removeCommandButton);
            this.commandGroupBox.Controls.Add(this.param2Label);
            this.commandGroupBox.Controls.Add(this.moveUpCommandButton);
            this.commandGroupBox.Controls.Add(this.param1Label);
            this.commandGroupBox.Controls.Add(this.addCommandButton);
            this.commandGroupBox.Controls.Add(this.param3NumUpDown);
            this.commandGroupBox.Controls.Add(this.param2NumUpDown);
            this.commandGroupBox.Controls.Add(this.commandListBox);
            this.commandGroupBox.Controls.Add(this.param1NumUpDown);
            this.commandGroupBox.Location = new System.Drawing.Point(228, 21);
            this.commandGroupBox.Name = "commandGroupBox";
            this.commandGroupBox.Size = new System.Drawing.Size(542, 402);
            this.commandGroupBox.TabIndex = 2;
            this.commandGroupBox.TabStop = false;
            this.commandGroupBox.Text = "Commands - Scene 1";
            // 
            // moveDownCommandButton
            // 
            this.moveDownCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveDownCommandButton.Location = new System.Drawing.Point(410, 359);
            this.moveDownCommandButton.Name = "moveDownCommandButton";
            this.moveDownCommandButton.Size = new System.Drawing.Size(105, 26);
            this.moveDownCommandButton.TabIndex = 13;
            this.moveDownCommandButton.Text = "Move Down";
            this.moveDownCommandButton.UseVisualStyleBackColor = true;
            this.moveDownCommandButton.Click += new System.EventHandler(this.moveDownCommandButton_Click);
            // 
            // param3Label
            // 
            this.param3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.param3Label.AutoSize = true;
            this.param3Label.Location = new System.Drawing.Point(145, 291);
            this.param3Label.Name = "param3Label";
            this.param3Label.Size = new System.Drawing.Size(70, 17);
            this.param3Label.TabIndex = 7;
            this.param3Label.Text = "Sound ID:";
            // 
            // removeCommandButton
            // 
            this.removeCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeCommandButton.Location = new System.Drawing.Point(299, 330);
            this.removeCommandButton.Name = "removeCommandButton";
            this.removeCommandButton.Size = new System.Drawing.Size(216, 23);
            this.removeCommandButton.TabIndex = 11;
            this.removeCommandButton.Text = "Remove Command";
            this.removeCommandButton.UseVisualStyleBackColor = true;
            this.removeCommandButton.Click += new System.EventHandler(this.removeCommandButton_Click);
            // 
            // param2Label
            // 
            this.param2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.param2Label.AutoSize = true;
            this.param2Label.Location = new System.Drawing.Point(81, 347);
            this.param2Label.Name = "param2Label";
            this.param2Label.Size = new System.Drawing.Size(48, 17);
            this.param2Label.TabIndex = 6;
            this.param2Label.Text = "Delay:";
            // 
            // moveUpCommandButton
            // 
            this.moveUpCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.moveUpCommandButton.Location = new System.Drawing.Point(299, 359);
            this.moveUpCommandButton.Name = "moveUpCommandButton";
            this.moveUpCommandButton.Size = new System.Drawing.Size(105, 26);
            this.moveUpCommandButton.TabIndex = 12;
            this.moveUpCommandButton.Text = "Move Up";
            this.moveUpCommandButton.UseVisualStyleBackColor = true;
            this.moveUpCommandButton.Click += new System.EventHandler(this.moveUpCommandButton_Click);
            // 
            // param1Label
            // 
            this.param1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.param1Label.AutoSize = true;
            this.param1Label.Location = new System.Drawing.Point(22, 291);
            this.param1Label.Name = "param1Label";
            this.param1Label.Size = new System.Drawing.Size(74, 17);
            this.param1Label.TabIndex = 5;
            this.param1Label.Text = "Handle ID:";
            // 
            // addCommandButton
            // 
            this.addCommandButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCommandButton.Location = new System.Drawing.Point(299, 301);
            this.addCommandButton.Name = "addCommandButton";
            this.addCommandButton.Size = new System.Drawing.Size(216, 23);
            this.addCommandButton.TabIndex = 10;
            this.addCommandButton.Text = "Add Command";
            this.addCommandButton.UseVisualStyleBackColor = true;
            this.addCommandButton.Click += new System.EventHandler(this.addCommandButton_Click);
            // 
            // param3NumUpDown
            // 
            this.param3NumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.param3NumUpDown.Location = new System.Drawing.Point(148, 314);
            this.param3NumUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.param3NumUpDown.Name = "param3NumUpDown";
            this.param3NumUpDown.Size = new System.Drawing.Size(120, 22);
            this.param3NumUpDown.TabIndex = 4;
            this.param3NumUpDown.ValueChanged += new System.EventHandler(this.paramNumUpDown_ValueChanged);
            // 
            // param2NumUpDown
            // 
            this.param2NumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.param2NumUpDown.Location = new System.Drawing.Point(84, 370);
            this.param2NumUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.param2NumUpDown.Name = "param2NumUpDown";
            this.param2NumUpDown.Size = new System.Drawing.Size(120, 22);
            this.param2NumUpDown.TabIndex = 1;
            this.param2NumUpDown.ValueChanged += new System.EventHandler(this.paramNumUpDown_ValueChanged);
            // 
            // commandListBox
            // 
            this.commandListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.HorizontalScrollbar = true;
            this.commandListBox.ItemHeight = 16;
            this.commandListBox.Location = new System.Drawing.Point(6, 21);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(530, 260);
            this.commandListBox.TabIndex = 3;
            this.commandListBox.SelectedIndexChanged += new System.EventHandler(this.commandListBox_SelectedIndexChanged);
            // 
            // param1NumUpDown
            // 
            this.param1NumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.param1NumUpDown.Location = new System.Drawing.Point(22, 314);
            this.param1NumUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.param1NumUpDown.Name = "param1NumUpDown";
            this.param1NumUpDown.Size = new System.Drawing.Size(120, 22);
            this.param1NumUpDown.TabIndex = 0;
            this.param1NumUpDown.ValueChanged += new System.EventHandler(this.paramNumUpDown_ValueChanged);
            // 
            // addSceneButton
            // 
            this.addSceneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addSceneButton.Location = new System.Drawing.Point(6, 367);
            this.addSceneButton.Name = "addSceneButton";
            this.addSceneButton.Size = new System.Drawing.Size(216, 23);
            this.addSceneButton.TabIndex = 5;
            this.addSceneButton.Text = "Add Scene";
            this.addSceneButton.UseVisualStyleBackColor = true;
            this.addSceneButton.Click += new System.EventHandler(this.addSceneButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.sceneGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Newer Cutscene Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sceneGroupBox.ResumeLayout(false);
            this.sceneGroupBox.PerformLayout();
            this.commandGroupBox.ResumeLayout(false);
            this.commandGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.param3NumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param2NumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.param1NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ListBox sceneListBox;
        private System.Windows.Forms.GroupBox sceneGroupBox;
        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.GroupBox commandGroupBox;
        private System.Windows.Forms.CheckBox widescreenCheckBox;
        private System.Windows.Forms.NumericUpDown param3NumUpDown;
        private System.Windows.Forms.NumericUpDown param2NumUpDown;
        private System.Windows.Forms.NumericUpDown param1NumUpDown;
        private System.Windows.Forms.Label param3Label;
        private System.Windows.Forms.Label param2Label;
        private System.Windows.Forms.Label param1Label;
        private System.Windows.Forms.Button removeSceneButton;
        private System.Windows.Forms.Button addSceneButton;
        private System.Windows.Forms.Button moveDownSceneButton;
        private System.Windows.Forms.Button moveUpSceneButton;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.Button moveDownCommandButton;
        private System.Windows.Forms.Button removeCommandButton;
        private System.Windows.Forms.Button moveUpCommandButton;
        private System.Windows.Forms.Button addCommandButton;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatePythonCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

