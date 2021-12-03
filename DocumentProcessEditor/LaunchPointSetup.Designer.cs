
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LaunchPointListBox
            // 
            this.LaunchPointListBox.FormattingEnabled = true;
            this.LaunchPointListBox.ItemHeight = 15;
            this.LaunchPointListBox.Location = new System.Drawing.Point(23, 48);
            this.LaunchPointListBox.Name = "LaunchPointListBox";
            this.LaunchPointListBox.Size = new System.Drawing.Size(239, 379);
            this.LaunchPointListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(281, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LaunchPointSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LaunchPointListBox);
            this.Name = "LaunchPointSetup";
            this.Text = "LaunchPointSetup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LaunchPointListBox;
        private System.Windows.Forms.Button button1;
    }
}