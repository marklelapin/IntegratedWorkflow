
namespace DocumentProcessEditor
{
    partial class LaunchPointSetup
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
            this.LaunchPointListBox = new System.Windows.Forms.ListBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SelectLaunchPointsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LaunchPointListBox
            // 
            this.LaunchPointListBox.FormattingEnabled = true;
            this.LaunchPointListBox.ItemHeight = 15;
            this.LaunchPointListBox.Location = new System.Drawing.Point(12, 33);
            this.LaunchPointListBox.MultiColumn = true;
            this.LaunchPointListBox.Name = "LaunchPointListBox";
            this.LaunchPointListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LaunchPointListBox.Size = new System.Drawing.Size(274, 364);
            this.LaunchPointListBox.TabIndex = 0;
           
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.White;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateButton.Location = new System.Drawing.Point(12, 486);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(274, 23);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SelectLaunchPointsLabel
            // 
            this.SelectLaunchPointsLabel.AutoSize = true;
            this.SelectLaunchPointsLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectLaunchPointsLabel.Name = "SelectLaunchPointsLabel";
            this.SelectLaunchPointsLabel.Size = new System.Drawing.Size(274, 15);
            this.SelectLaunchPointsLabel.TabIndex = 2;
            this.SelectLaunchPointsLabel.Text = "Select Launch Points to Add to Document Process:";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddButton.Location = new System.Drawing.Point(163, 403);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.Location = new System.Drawing.Point(12, 403);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(125, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "or Create a new one:";
            // 
            // CreateTextBox
            // 
            this.CreateTextBox.Location = new System.Drawing.Point(11, 457);
            this.CreateTextBox.Name = "CreateTextBox";
            this.CreateTextBox.Size = new System.Drawing.Size(275, 23);
            this.CreateTextBox.TabIndex = 7;
            // 
            // LaunchPointSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 521);
            this.Controls.Add(this.CreateTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SelectLaunchPointsLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.LaunchPointListBox);
            this.Name = "LaunchPointSetup";
            this.Text = "LaunchPointSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LaunchPointListBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label SelectLaunchPointsLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateTextBox;
    }
}