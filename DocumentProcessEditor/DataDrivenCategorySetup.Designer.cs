
namespace DocumentProcessEditor
{
    partial class DataDrivenCategorySetup
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
            this.LookupListBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectLookupLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.LookupResultsLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LookupListBox
            // 
            this.LookupListBox.FormattingEnabled = true;
            this.LookupListBox.ItemHeight = 15;
            this.LookupListBox.Location = new System.Drawing.Point(16, 93);
            this.LookupListBox.Name = "LookupListBox";
            this.LookupListBox.Size = new System.Drawing.Size(231, 304);
            this.LookupListBox.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(16, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 21);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // SelectLookupLabel
            // 
            this.SelectLookupLabel.AutoSize = true;
            this.SelectLookupLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectLookupLabel.Location = new System.Drawing.Point(16, 64);
            this.SelectLookupLabel.Name = "SelectLookupLabel";
            this.SelectLookupLabel.Size = new System.Drawing.Size(133, 21);
            this.SelectLookupLabel.TabIndex = 2;
            this.SelectLookupLabel.Text = "Select LookUp list";
            this.SelectLookupLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.Location = new System.Drawing.Point(187, 415);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 15;
            this.ResultsListBox.Location = new System.Drawing.Point(294, 93);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ResultsListBox.Size = new System.Drawing.Size(235, 300);
            this.ResultsListBox.TabIndex = 4;
            // 
            // LookupResultsLabel
            // 
            this.LookupResultsLabel.AutoSize = true;
            this.LookupResultsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LookupResultsLabel.Location = new System.Drawing.Point(294, 64);
            this.LookupResultsLabel.Name = "LookupResultsLabel";
            this.LookupResultsLabel.Size = new System.Drawing.Size(119, 21);
            this.LookupResultsLabel.TabIndex = 5;
            this.LookupResultsLabel.Text = "Lookup Results:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(62, 18);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(448, 23);
            this.TitleTextBox.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.Location = new System.Drawing.Point(320, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // DataDrivenCategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.LookupResultsLabel);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SelectLookupLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LookupListBox);
            this.Name = "DataDrivenCategorySetup";
            this.Text = "DataDrivenCategorySetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LookupListBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SelectLookupLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Label LookupResultsLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button CancelButton;
    }
}