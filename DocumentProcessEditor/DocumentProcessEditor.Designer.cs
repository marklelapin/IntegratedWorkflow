
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
            this.DocumentProcessListBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ObjectListBox = new System.Windows.Forms.ListBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.Objects = new System.Windows.Forms.Label();
            this.SeachLabel = new System.Windows.Forms.Label();
            this.AccessLabel = new System.Windows.Forms.Label();
            this.DocumentProcessGroup = new System.Windows.Forms.GroupBox();
            this.DocumentProcessNameErrorMessage = new System.Windows.Forms.Label();
            this.SelectedDocumentProcessID = new System.Windows.Forms.Label();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.LaunchPointsLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.DocumentProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.IsActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.DocumentProcessIDLabel = new System.Windows.Forms.Label();
            this.LaunchPointsListBox = new System.Windows.Forms.ListBox();
            this.AddNewAccessEntityButton = new System.Windows.Forms.Button();
            this.AddNewObjectButton = new System.Windows.Forms.Button();
            this.AccessListBox = new System.Windows.Forms.ListBox();
            this.CreateNewDocumentProcessButton = new System.Windows.Forms.Button();
            AddLaunchPointButton = new System.Windows.Forms.Button();
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
            AddLaunchPointButton.Location = new System.Drawing.Point(503, 252);
            AddLaunchPointButton.Name = "AddLaunchPointButton";
            AddLaunchPointButton.Size = new System.Drawing.Size(69, 23);
            AddLaunchPointButton.TabIndex = 20;
            AddLaunchPointButton.Text = "Add New";
            AddLaunchPointButton.UseVisualStyleBackColor = false;
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
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
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
            // AccessLabel
            // 
            this.AccessLabel.AutoSize = true;
            this.AccessLabel.Location = new System.Drawing.Point(306, 78);
            this.AccessLabel.Name = "AccessLabel";
            this.AccessLabel.Size = new System.Drawing.Size(53, 20);
            this.AccessLabel.TabIndex = 9;
            this.AccessLabel.Text = "Access";
            // 
            // DocumentProcessGroup
            // 
            this.DocumentProcessGroup.Controls.Add(this.DocumentProcessNameErrorMessage);
            this.DocumentProcessGroup.Controls.Add(this.SelectedDocumentProcessID);
            this.DocumentProcessGroup.Controls.Add(this.CancelChangesButton);
            this.DocumentProcessGroup.Controls.Add(this.AccessLabel);
            this.DocumentProcessGroup.Controls.Add(this.LaunchPointsLabel);
            this.DocumentProcessGroup.Controls.Add(this.SaveChangesButton);
            this.DocumentProcessGroup.Controls.Add(this.DocumentProcessNameTextBox);
            this.DocumentProcessGroup.Controls.Add(this.IsActiveCheckBox);
            this.DocumentProcessGroup.Controls.Add(this.DocumentProcessIDLabel);
            this.DocumentProcessGroup.Controls.Add(AddLaunchPointButton);
            this.DocumentProcessGroup.Controls.Add(this.LaunchPointsListBox);
            this.DocumentProcessGroup.Controls.Add(this.AddNewAccessEntityButton);
            this.DocumentProcessGroup.Controls.Add(this.AddNewObjectButton);
            this.DocumentProcessGroup.Controls.Add(this.AccessListBox);
            this.DocumentProcessGroup.Controls.Add(this.Objects);
            this.DocumentProcessGroup.Controls.Add(this.ObjectListBox);
            this.DocumentProcessGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocumentProcessGroup.Location = new System.Drawing.Point(311, 9);
            this.DocumentProcessGroup.Name = "DocumentProcessGroup";
            this.DocumentProcessGroup.Size = new System.Drawing.Size(576, 460);
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
            // SelectedDocumentProcessID
            // 
            this.SelectedDocumentProcessID.AutoSize = true;
            this.SelectedDocumentProcessID.Location = new System.Drawing.Point(539, 1);
            this.SelectedDocumentProcessID.Name = "SelectedDocumentProcessID";
            this.SelectedDocumentProcessID.Size = new System.Drawing.Size(27, 20);
            this.SelectedDocumentProcessID.TabIndex = 24;
            this.SelectedDocumentProcessID.Text = "---";
            this.SelectedDocumentProcessID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.BackColor = System.Drawing.Color.White;
            this.CancelChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChangesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelChangesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelChangesButton.Location = new System.Drawing.Point(453, 424);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(102, 25);
            this.CancelChangesButton.TabIndex = 17;
            this.CancelChangesButton.Text = "Cancel Changes";
            this.CancelChangesButton.UseVisualStyleBackColor = false;
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
            this.SaveChangesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveChangesButton.Location = new System.Drawing.Point(327, 424);
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
            this.DocumentProcessNameTextBox.Size = new System.Drawing.Size(477, 27);
            this.DocumentProcessNameTextBox.TabIndex = 18;
            // 
            // IsActiveCheckBox
            // 
            this.IsActiveCheckBox.AutoSize = true;
            this.IsActiveCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsActiveCheckBox.Location = new System.Drawing.Point(489, 26);
            this.IsActiveCheckBox.Name = "IsActiveCheckBox";
            this.IsActiveCheckBox.Size = new System.Drawing.Size(83, 24);
            this.IsActiveCheckBox.TabIndex = 23;
            this.IsActiveCheckBox.Text = "Is Active";
            this.IsActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // DocumentProcessIDLabel
            // 
            this.DocumentProcessIDLabel.AutoSize = true;
            this.DocumentProcessIDLabel.Location = new System.Drawing.Point(498, 1);
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
            this.LaunchPointsListBox.Size = new System.Drawing.Size(266, 140);
            this.LaunchPointsListBox.TabIndex = 19;
            // 
            // AddNewAccessEntityButton
            // 
            this.AddNewAccessEntityButton.BackColor = System.Drawing.Color.White;
            this.AddNewAccessEntityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddNewAccessEntityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewAccessEntityButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewAccessEntityButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewAccessEntityButton.Location = new System.Drawing.Point(503, 74);
            this.AddNewAccessEntityButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AddNewAccessEntityButton.Name = "AddNewAccessEntityButton";
            this.AddNewAccessEntityButton.Size = new System.Drawing.Size(69, 23);
            this.AddNewAccessEntityButton.TabIndex = 14;
            this.AddNewAccessEntityButton.Text = "Add New";
            this.AddNewAccessEntityButton.UseVisualStyleBackColor = false;
            // 
            // AddNewObjectButton
            // 
            this.AddNewObjectButton.BackColor = System.Drawing.Color.White;
            this.AddNewObjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddNewObjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewObjectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewObjectButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewObjectButton.Location = new System.Drawing.Point(203, 74);
            this.AddNewObjectButton.Name = "AddNewObjectButton";
            this.AddNewObjectButton.Size = new System.Drawing.Size(69, 23);
            this.AddNewObjectButton.TabIndex = 13;
            this.AddNewObjectButton.Text = "Add New";
            this.AddNewObjectButton.UseVisualStyleBackColor = false;
            // 
            // AccessListBox
            // 
            this.AccessListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessListBox.FormattingEnabled = true;
            this.AccessListBox.HorizontalScrollbar = true;
            this.AccessListBox.ItemHeight = 17;
            this.AccessListBox.Location = new System.Drawing.Point(306, 101);
            this.AccessListBox.Name = "AccessListBox";
            this.AccessListBox.Size = new System.Drawing.Size(266, 140);
            this.AccessListBox.TabIndex = 11;
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
            // DocumentProcessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 480);
            this.Controls.Add(this.CreateNewDocumentProcessButton);
            this.Controls.Add(this.SeachLabel);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DocumentProcessListBox);
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
        private System.Windows.Forms.Label AccessLabel;
        private System.Windows.Forms.GroupBox DocumentProcessGroup;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.Button AddNewAccessEntityButton;
        private System.Windows.Forms.Button AddNewObjectButton;
        private System.Windows.Forms.ListBox AccessListBox;
        private System.Windows.Forms.Button CreateNewDocumentProcessButton;
        private System.Windows.Forms.ListBox LaunchPointsListBox;
        private System.Windows.Forms.Label LaunchPointsLabel;
        private System.Windows.Forms.Label DocumentProcessIDLabel;
        private System.Windows.Forms.TextBox DocumentProcessNameTextBox;
        private System.Windows.Forms.CheckBox IsActiveCheckBox;
        private System.Windows.Forms.Label SelectedDocumentProcessID;
        private System.Windows.Forms.Label DocumentProcessNameErrorMessage;
    }
}

