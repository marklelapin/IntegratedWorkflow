
namespace DocumentProcessEditor
{
    partial class DocumentProcessEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button AddLaunchPointButton;
            System.Windows.Forms.Button RemoveLaunchPointButton;
            System.Windows.Forms.Button RemoveAccessEntityButton;
            System.Windows.Forms.Button RemoveObjectButton;
            this.DocumentProcessListBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ObjectListBox = new System.Windows.Forms.ListBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.Objects = new System.Windows.Forms.Label();
            this.SeachLabel = new System.Windows.Forms.Label();
            this.AccessRulesLabel = new System.Windows.Forms.Label();
            this.DocumentProcessGroup = new System.Windows.Forms.GroupBox();
            this.DocumentProcessNameErrorMessage = new System.Windows.Forms.Label();
            this.SelectedDocumentProcessIDLabel = new System.Windows.Forms.Label();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.LaunchPointsLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.DocumentProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.DocumentProcessIDLabel = new System.Windows.Forms.Label();
            this.LaunchPointsListBox = new System.Windows.Forms.ListBox();
            this.AddAccessEntityButton = new System.Windows.Forms.Button();
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.AccessRulesListBox = new System.Windows.Forms.ListBox();
            this.CreateNewDocumentProcessButton = new System.Windows.Forms.Button();
            this.ActiveOnlyCheckBox = new System.Windows.Forms.CheckBox();
            AddLaunchPointButton = new System.Windows.Forms.Button();
            RemoveLaunchPointButton = new System.Windows.Forms.Button();
            RemoveAccessEntityButton = new System.Windows.Forms.Button();
            RemoveObjectButton = new System.Windows.Forms.Button();
            this.DocumentProcessGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddLaunchPointButton
            // 
            AddLaunchPointButton.BackColor = System.Drawing.Color.White;
            AddLaunchPointButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            AddLaunchPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddLaunchPointButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddLaunchPointButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            AddLaunchPointButton.Location = new System.Drawing.Point(528, 252);
            AddLaunchPointButton.Name = "AddLaunchPointButton";
            AddLaunchPointButton.Size = new System.Drawing.Size(44, 23);
            AddLaunchPointButton.TabIndex = 20;
            AddLaunchPointButton.Text = "Add";
            AddLaunchPointButton.UseVisualStyleBackColor = false;
            AddLaunchPointButton.Click += new System.EventHandler(this.AddLaunchPointButton_Click);
            // 
            // RemoveLaunchPointButton
            // 
            RemoveLaunchPointButton.BackColor = System.Drawing.Color.White;
            RemoveLaunchPointButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            RemoveLaunchPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RemoveLaunchPointButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RemoveLaunchPointButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            RemoveLaunchPointButton.Location = new System.Drawing.Point(579, 252);
            RemoveLaunchPointButton.Name = "RemoveLaunchPointButton";
            RemoveLaunchPointButton.Size = new System.Drawing.Size(61, 23);
            RemoveLaunchPointButton.TabIndex = 26;
            RemoveLaunchPointButton.Text = "Remove";
            RemoveLaunchPointButton.UseVisualStyleBackColor = false;
            RemoveLaunchPointButton.Click += new System.EventHandler(this.RemoveLaunchPointButton_Click);
            // 
            // RemoveAccessEntityButton
            // 
            RemoveAccessEntityButton.BackColor = System.Drawing.Color.White;
            RemoveAccessEntityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            RemoveAccessEntityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RemoveAccessEntityButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RemoveAccessEntityButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            RemoveAccessEntityButton.Location = new System.Drawing.Point(579, 75);
            RemoveAccessEntityButton.Name = "RemoveAccessEntityButton";
            RemoveAccessEntityButton.Size = new System.Drawing.Size(61, 23);
            RemoveAccessEntityButton.TabIndex = 27;
            RemoveAccessEntityButton.Text = "Remove";
            RemoveAccessEntityButton.UseVisualStyleBackColor = false;
            RemoveAccessEntityButton.Click += new System.EventHandler(this.RemoveAccessEntityButton_Click);
            // 
            // RemoveObjectButton
            // 
            RemoveObjectButton.BackColor = System.Drawing.Color.White;
            RemoveObjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            RemoveObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RemoveObjectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            RemoveObjectButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            RemoveObjectButton.Location = new System.Drawing.Point(211, 75);
            RemoveObjectButton.Name = "RemoveObjectButton";
            RemoveObjectButton.Size = new System.Drawing.Size(61, 23);
            RemoveObjectButton.TabIndex = 28;
            RemoveObjectButton.Text = "Remove";
            RemoveObjectButton.UseVisualStyleBackColor = false;
            // 
            // DocumentProcessListBox
            // 
            this.DocumentProcessListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentProcessListBox.FormattingEnabled = true;
            this.DocumentProcessListBox.ItemHeight = 17;
            this.DocumentProcessListBox.Location = new System.Drawing.Point(12, 91);
            this.DocumentProcessListBox.Name = "DocumentProcessListBox";
            this.DocumentProcessListBox.Size = new System.Drawing.Size(281, 378);
            this.DocumentProcessListBox.TabIndex = 0;
            this.DocumentProcessListBox.SelectedIndexChanged += new System.EventHandler(this.DocumentProcessListBox_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(145, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Document Processes";
            // 
            // ObjectListBox
            // 
            this.ObjectListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ObjectListBox.FormattingEnabled = true;
            this.ObjectListBox.ItemHeight = 17;
            this.ObjectListBox.Location = new System.Drawing.Point(6, 101);
            this.ObjectListBox.Name = "ObjectListBox";
            this.ObjectListBox.Size = new System.Drawing.Size(266, 342);
            this.ObjectListBox.TabIndex = 2;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(93, 48);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(200, 27);
            this.SearchTextbox.TabIndex = 4;
            this.SearchTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchTextbox_KeyUp);
            // 
            // Objects
            // 
            this.Objects.AutoSize = true;
            this.Objects.Location = new System.Drawing.Point(6, 78);
            this.Objects.Name = "Objects";
            this.Objects.Size = new System.Drawing.Size(59, 20);
            this.Objects.TabIndex = 7;
            this.Objects.Text = "Objects";
            // 
            // SeachLabel
            // 
            this.SeachLabel.AutoSize = true;
            this.SeachLabel.Location = new System.Drawing.Point(12, 51);
            this.SeachLabel.Name = "SeachLabel";
            this.SeachLabel.Size = new System.Drawing.Size(56, 20);
            this.SeachLabel.TabIndex = 8;
            this.SeachLabel.Text = "Search:";
            // 
            // AccessRulesLabel
            // 
            this.AccessRulesLabel.AutoSize = true;
            this.AccessRulesLabel.Location = new System.Drawing.Point(306, 78);
            this.AccessRulesLabel.Name = "AccessRulesLabel";
            this.AccessRulesLabel.Size = new System.Drawing.Size(92, 20);
            this.AccessRulesLabel.TabIndex = 9;
            this.AccessRulesLabel.Text = "Access Rules";
            // 
            // DocumentProcessGroup
            // 
            this.DocumentProcessGroup.Controls.Add(RemoveObjectButton);
            this.DocumentProcessGroup.Controls.Add(RemoveAccessEntityButton);
            this.DocumentProcessGroup.Controls.Add(RemoveLaunchPointButton);
            this.DocumentProcessGroup.Controls.Add(this.DocumentProcessNameErrorMessage);
            this.DocumentProcessGroup.Controls.Add(this.SelectedDocumentProcessIDLabel);
            this.DocumentProcessGroup.Controls.Add(this.CancelChangesButton);
            this.DocumentProcessGroup.Controls.Add(this.AccessRulesLabel);
            this.DocumentProcessGroup.Controls.Add(this.LaunchPointsLabel);
            this.DocumentProcessGroup.Controls.Add(this.SaveChangesButton);
            this.DocumentProcessGroup.Controls.Add(this.DocumentProcessNameTextBox);
            this.DocumentProcessGroup.Controls.Add(this.IsActiveCheckBox);
            this.DocumentProcessGroup.Controls.Add(this.DocumentProcessIDLabel);
            this.DocumentProcessGroup.Controls.Add(AddLaunchPointButton);
            this.DocumentProcessGroup.Controls.Add(this.LaunchPointsListBox);
            this.DocumentProcessGroup.Controls.Add(this.AddAccessEntityButton);
            this.DocumentProcessGroup.Controls.Add(this.AddObjectButton);
            this.DocumentProcessGroup.Controls.Add(this.AccessRulesListBox);
            this.DocumentProcessGroup.Controls.Add(this.Objects);
            this.DocumentProcessGroup.Controls.Add(this.ObjectListBox);
            this.DocumentProcessGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocumentProcessGroup.Location = new System.Drawing.Point(311, 9);
            this.DocumentProcessGroup.Name = "DocumentProcessGroup";
            this.DocumentProcessGroup.Size = new System.Drawing.Size(652, 460);
            this.DocumentProcessGroup.TabIndex = 10;
            this.DocumentProcessGroup.TabStop = false;
            this.DocumentProcessGroup.Text = "Selected Document Process: ";
            // 
            // DocumentProcessNameErrorMessage
            // 
            this.DocumentProcessNameErrorMessage.AutoSize = true;
            this.DocumentProcessNameErrorMessage.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentProcessNameErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.DocumentProcessNameErrorMessage.Location = new System.Drawing.Point(6, 53);
            this.DocumentProcessNameErrorMessage.Name = "DocumentProcessNameErrorMessage";
            this.DocumentProcessNameErrorMessage.Size = new System.Drawing.Size(80, 13);
            this.DocumentProcessNameErrorMessage.TabIndex = 25;
            this.DocumentProcessNameErrorMessage.Text = "Error Message";
            this.DocumentProcessNameErrorMessage.Visible = false;
            // 
            // SelectedDocumentProcessIDLabel
            // 
            this.SelectedDocumentProcessIDLabel.AutoSize = true;
            this.SelectedDocumentProcessIDLabel.Location = new System.Drawing.Point(600, 0);
            this.SelectedDocumentProcessIDLabel.Name = "SelectedDocumentProcessIDLabel";
            this.SelectedDocumentProcessIDLabel.Size = new System.Drawing.Size(27, 20);
            this.SelectedDocumentProcessIDLabel.TabIndex = 24;
            this.SelectedDocumentProcessIDLabel.Text = "---";
            this.SelectedDocumentProcessIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.BackColor = System.Drawing.Color.White;
            this.CancelChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChangesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelChangesButton.ForeColor = System.Drawing.Color.Red;
            this.CancelChangesButton.Location = new System.Drawing.Point(501, 424);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(102, 25);
            this.CancelChangesButton.TabIndex = 17;
            this.CancelChangesButton.Text = "Cancel Changes";
            this.CancelChangesButton.UseVisualStyleBackColor = false;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // LaunchPointsLabel
            // 
            this.LaunchPointsLabel.AutoSize = true;
            this.LaunchPointsLabel.Location = new System.Drawing.Point(306, 255);
            this.LaunchPointsLabel.Name = "LaunchPointsLabel";
            this.LaunchPointsLabel.Size = new System.Drawing.Size(98, 20);
            this.LaunchPointsLabel.TabIndex = 18;
            this.LaunchPointsLabel.Text = "Launch Points";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.White;
            this.SaveChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveChangesButton.ForeColor = System.Drawing.Color.Lime;
            this.SaveChangesButton.Location = new System.Drawing.Point(377, 424);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(102, 25);
            this.SaveChangesButton.TabIndex = 16;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // DocumentProcessNameTextBox
            // 
            this.DocumentProcessNameTextBox.Location = new System.Drawing.Point(6, 26);
            this.DocumentProcessNameTextBox.Name = "DocumentProcessNameTextBox";
            this.DocumentProcessNameTextBox.Size = new System.Drawing.Size(545, 27);
            this.DocumentProcessNameTextBox.TabIndex = 18;
            this.DocumentProcessNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DocumentProcessNameTextBox_KeyUp);
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsActiveCheckBox.Location = new System.Drawing.Point(557, 28);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(83, 24);
            this.IsActiveCheckBox.TabIndex = 23;
            this.IsActiveCheckBox.Text = "Is Active";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // DocumentProcessIDLabel
            // 
            this.DocumentProcessIDLabel.AutoSize = true;
            this.DocumentProcessIDLabel.Location = new System.Drawing.Point(557, 0);
            this.DocumentProcessIDLabel.Name = "DocumentProcessIDLabel";
            this.DocumentProcessIDLabel.Size = new System.Drawing.Size(46, 20);
            this.DocumentProcessIDLabel.TabIndex = 21;
            this.DocumentProcessIDLabel.Text = "DPID:";
            this.DocumentProcessIDLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LaunchPointsListBox
            // 
            this.LaunchPointsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaunchPointsListBox.FormattingEnabled = true;
            this.LaunchPointsListBox.ItemHeight = 17;
            this.LaunchPointsListBox.Location = new System.Drawing.Point(306, 278);
            this.LaunchPointsListBox.Name = "LaunchPointsListBox";
            this.LaunchPointsListBox.Size = new System.Drawing.Size(334, 140);
            this.LaunchPointsListBox.TabIndex = 19;
            // 
            // AddAccessEntityButton
            // 
            this.AddAccessEntityButton.BackColor = System.Drawing.Color.White;
            this.AddAccessEntityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddAccessEntityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccessEntityButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddAccessEntityButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddAccessEntityButton.Location = new System.Drawing.Point(528, 75);
            this.AddAccessEntityButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AddAccessEntityButton.Name = "AddAccessEntityButton";
            this.AddAccessEntityButton.Size = new System.Drawing.Size(44, 23);
            this.AddAccessEntityButton.TabIndex = 14;
            this.AddAccessEntityButton.Text = "Add";
            this.AddAccessEntityButton.UseVisualStyleBackColor = false;
            this.AddAccessEntityButton.Click += new System.EventHandler(this.AddAccessEntityButton_Click);
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.BackColor = System.Drawing.Color.White;
            this.AddObjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddObjectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddObjectButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddObjectButton.Location = new System.Drawing.Point(161, 75);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(44, 23);
            this.AddObjectButton.TabIndex = 13;
            this.AddObjectButton.Text = "Add";
            this.AddObjectButton.UseVisualStyleBackColor = false;
            // 
            // AccessRulesListBox
            // 
            this.AccessRulesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessRulesListBox.FormattingEnabled = true;
            this.AccessRulesListBox.HorizontalScrollbar = true;
            this.AccessRulesListBox.ItemHeight = 17;
            this.AccessRulesListBox.Location = new System.Drawing.Point(306, 101);
            this.AccessRulesListBox.Name = "AccessRulesListBox";
            this.AccessRulesListBox.Size = new System.Drawing.Size(334, 140);
            this.AccessRulesListBox.TabIndex = 11;
            // 
            // CreateNewDocumentProcessButton
            // 
            this.CreateNewDocumentProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewDocumentProcessButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateNewDocumentProcessButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateNewDocumentProcessButton.Location = new System.Drawing.Point(211, 12);
            this.CreateNewDocumentProcessButton.Name = "CreateNewDocumentProcessButton";
            this.CreateNewDocumentProcessButton.Size = new System.Drawing.Size(82, 23);
            this.CreateNewDocumentProcessButton.TabIndex = 11;
            this.CreateNewDocumentProcessButton.Text = "Create New";
            this.CreateNewDocumentProcessButton.UseVisualStyleBackColor = true;
            this.CreateNewDocumentProcessButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // ActiveOnlyCheckBox
            // 
            this.ActiveOnlyCheckBox.AutoSize = true;
            this.ActiveOnlyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ActiveOnlyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActiveOnlyCheckBox.Checked = true;
            this.ActiveOnlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActiveOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveOnlyCheckBox.Location = new System.Drawing.Point(191, 76);
            this.ActiveOnlyCheckBox.Name = "ActiveOnlyCheckBox";
            this.ActiveOnlyCheckBox.Size = new System.Drawing.Size(103, 17);
            this.ActiveOnlyCheckBox.TabIndex = 12;
            this.ActiveOnlyCheckBox.Text = "Active DPs only";
            this.ActiveOnlyCheckBox.UseVisualStyleBackColor = false;
            this.ActiveOnlyCheckBox.CheckedChanged += new System.EventHandler(this.ActiveOnlyCheckBox_CheckedChanged);
            // 
            // DocumentProcessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 476);
            this.Controls.Add(this.DocumentProcessListBox);
            this.Controls.Add(this.ActiveOnlyCheckBox);
            this.Controls.Add(this.CreateNewDocumentProcessButton);
            this.Controls.Add(this.SeachLabel);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DocumentProcessGroup);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DocumentProcessEditor";
            this.Text = "DocumentProcessEditor";
            this.DocumentProcessGroup.ResumeLayout(false);
            this.DocumentProcessGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DocumentProcessListBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox ObjectListBox;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label Objects;
        private System.Windows.Forms.Label SeachLabel;
        private System.Windows.Forms.Label AccessRulesLabel;
        private System.Windows.Forms.GroupBox DocumentProcessGroup;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button AddAccessEntityButton;
        private System.Windows.Forms.Button AddObjectButton;
        private System.Windows.Forms.ListBox AccessRulesListBox;
        private System.Windows.Forms.Button CreateNewDocumentProcessButton;
        private System.Windows.Forms.ListBox LaunchPointsListBox;
        private System.Windows.Forms.Label LaunchPointsLabel;
        private System.Windows.Forms.Label DocumentProcessIDLabel;
        private System.Windows.Forms.TextBox DocumentProcessNameTextBox;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.Label SelectedDocumentProcessIDLabel;
        private System.Windows.Forms.Label DocumentProcessNameErrorMessage;
        private System.Windows.Forms.CheckBox ActiveOnlyCheckBox;
    }
}

