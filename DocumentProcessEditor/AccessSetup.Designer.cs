
namespace DocumentProcessEditor
{
    partial class AccessSetup
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
            this.AccessEntityTypeLabel = new System.Windows.Forms.Label();
            this.AccessEntityLabel = new System.Windows.Forms.Label();
            this.AccessType = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AccessEntityTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AccessEntityComboBox = new System.Windows.Forms.ComboBox();
            this.AccessTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AccessEntityTypeLabel
            // 
            this.AccessEntityTypeLabel.AutoSize = true;
            this.AccessEntityTypeLabel.Location = new System.Drawing.Point(19, 13);
            this.AccessEntityTypeLabel.Name = "AccessEntityTypeLabel";
            this.AccessEntityTypeLabel.Size = new System.Drawing.Size(97, 15);
            this.AccessEntityTypeLabel.TabIndex = 0;
            this.AccessEntityTypeLabel.Text = "AccessEntityType";
            // 
            // AccessEntityLabel
            // 
            this.AccessEntityLabel.AutoSize = true;
            this.AccessEntityLabel.Location = new System.Drawing.Point(19, 81);
            this.AccessEntityLabel.Name = "AccessEntityLabel";
            this.AccessEntityLabel.Size = new System.Drawing.Size(73, 15);
            this.AccessEntityLabel.TabIndex = 2;
            this.AccessEntityLabel.Text = "AccessEntity";
            // 
            // AccessType
            // 
            this.AccessType.AutoSize = true;
            this.AccessType.Location = new System.Drawing.Point(19, 150);
            this.AccessType.Name = "AccessType";
            this.AccessType.Size = new System.Drawing.Size(67, 15);
            this.AccessType.TabIndex = 4;
            this.AccessType.Text = "AccessType";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(89, 208);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(184, 208);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AccessEntityTypeComboBox
            // 
            this.AccessEntityTypeComboBox.FormattingEnabled = true;
            this.AccessEntityTypeComboBox.Location = new System.Drawing.Point(19, 31);
            this.AccessEntityTypeComboBox.Name = "AccessEntityTypeComboBox";
            this.AccessEntityTypeComboBox.Size = new System.Drawing.Size(312, 23);
            this.AccessEntityTypeComboBox.TabIndex = 8;
            this.AccessEntityTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AccessEntityTypeComboBox_SelectedIndexChanged);
            // 
            // AccessEntityComboBox
            // 
            this.AccessEntityComboBox.FormattingEnabled = true;
            this.AccessEntityComboBox.Location = new System.Drawing.Point(19, 99);
            this.AccessEntityComboBox.Name = "AccessEntityComboBox";
            this.AccessEntityComboBox.Size = new System.Drawing.Size(312, 23);
            this.AccessEntityComboBox.TabIndex = 9;
            // 
            // AccessTypeComboBox
            // 
            this.AccessTypeComboBox.FormattingEnabled = true;
            this.AccessTypeComboBox.Location = new System.Drawing.Point(19, 168);
            this.AccessTypeComboBox.Name = "AccessTypeComboBox";
            this.AccessTypeComboBox.Size = new System.Drawing.Size(312, 23);
            this.AccessTypeComboBox.TabIndex = 10;
            // 
            // AccessSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 245);
            this.Controls.Add(this.AccessTypeComboBox);
            this.Controls.Add(this.AccessEntityComboBox);
            this.Controls.Add(this.AccessEntityTypeComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AccessType);
            this.Controls.Add(this.AccessEntityLabel);
            this.Controls.Add(this.AccessEntityTypeLabel);
            this.Name = "AccessSetup";
            this.Text = "AccessSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccessEntityTypeLabel;
        private System.Windows.Forms.Label AccessEntityLabel;
        private System.Windows.Forms.Label AccessType;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox AccessEntityTypeComboBox;
        private System.Windows.Forms.ComboBox AccessEntityComboBox;
        private System.Windows.Forms.ComboBox AccessTypeComboBox;
    }
}