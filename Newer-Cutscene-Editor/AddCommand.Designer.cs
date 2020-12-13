namespace Newer_Cutscene_Editor
{
    partial class AddCommand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.commandLabel = new System.Windows.Forms.Label();
            this.commandComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(9, 9);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(248, 17);
            this.commandLabel.TabIndex = 0;
            this.commandLabel.Text = "Which command do you want to add ?";
            // 
            // commandComboBox
            // 
            this.commandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commandComboBox.FormattingEnabled = true;
            this.commandComboBox.Items.AddRange(new object[] {
            "Play Sound",
            "Play Looping Sound",
            "Stop Looping Sound"});
            this.commandComboBox.Location = new System.Drawing.Point(12, 33);
            this.commandComboBox.Name = "commandComboBox";
            this.commandComboBox.Size = new System.Drawing.Size(294, 24);
            this.commandComboBox.TabIndex = 1;
            this.commandComboBox.SelectedIndexChanged += new System.EventHandler(this.commandComboBox_SelectedIndexChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(122, 63);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 98);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.commandComboBox);
            this.Controls.Add(this.commandLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCommand";
            this.ShowIcon = false;
            this.Text = "Add Command";
            this.Load += new System.EventHandler(this.AddCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.ComboBox commandComboBox;
        private System.Windows.Forms.Button okButton;
    }
}