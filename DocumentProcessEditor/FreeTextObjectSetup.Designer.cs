
namespace DocumentProcessEditor
{
    partial class FreeTextObjectSetup
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MaxLengthLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MaxLengthTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IsOptionalCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(116, 21);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title / Question";
            // 
            // MaxLengthLabel
            // 
            this.MaxLengthLabel.AutoSize = true;
            this.MaxLengthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxLengthLabel.Location = new System.Drawing.Point(37, 51);
            this.MaxLengthLabel.Name = "MaxLengthLabel";
            this.MaxLengthLabel.Size = new System.Drawing.Size(91, 21);
            this.MaxLengthLabel.TabIndex = 2;
            this.MaxLengthLabel.Text = "Max Length";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleTextBox.Location = new System.Drawing.Point(134, 6);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(530, 29);
            this.TitleTextBox.TabIndex = 3;
            // 
            // MaxLengthTextBox
            // 
            this.MaxLengthTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxLengthTextBox.Location = new System.Drawing.Point(134, 48);
            this.MaxLengthTextBox.Name = "MaxLengthTextBox";
            this.MaxLengthTextBox.Size = new System.Drawing.Size(61, 29);
            this.MaxLengthTextBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.Location = new System.Drawing.Point(265, 97);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.Location = new System.Drawing.Point(363, 97);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // IsOptionalCheckBox
            // 
            this.IsOptionalCheckBox.AutoSize = true;
            this.IsOptionalCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsOptionalCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsOptionalCheckBox.Location = new System.Drawing.Point(229, 50);
            this.IsOptionalCheckBox.Name = "IsOptionalCheckBox";
            this.IsOptionalCheckBox.Size = new System.Drawing.Size(111, 25);
            this.IsOptionalCheckBox.TabIndex = 7;
            this.IsOptionalCheckBox.Text = "Is Optional?";
            this.IsOptionalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TextObjectSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 135);
            this.Controls.Add(this.IsOptionalCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MaxLengthTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.MaxLengthLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "TextObjectSetup";
            this.Text = "FreeTextSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MaxLengthLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox MaxLengthTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox IsOptionalCheckBox;
    }
}