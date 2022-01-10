
namespace DocumentProcessEditor
{
    partial class ObjectSelection
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
            this.SelectObjectTypeLabel = new System.Windows.Forms.Label();
            this.ObjectTypeListBox = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectObjectTypeLabel
            // 
            this.SelectObjectTypeLabel.AutoSize = true;
            this.SelectObjectTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectObjectTypeLabel.Name = "SelectObjectTypeLabel";
            this.SelectObjectTypeLabel.Size = new System.Drawing.Size(103, 15);
            this.SelectObjectTypeLabel.TabIndex = 0;
            this.SelectObjectTypeLabel.Text = "Select Object Type";
   
            // 
            // ObjectTypeListBox
            // 
            this.ObjectTypeListBox.FormattingEnabled = true;
            this.ObjectTypeListBox.ItemHeight = 15;
            this.ObjectTypeListBox.Location = new System.Drawing.Point(8, 33);
            this.ObjectTypeListBox.Name = "ObjectTypeListBox";
            this.ObjectTypeListBox.Size = new System.Drawing.Size(255, 379);
            this.ObjectTypeListBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(40, 418);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(147, 418);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ObjectSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ObjectTypeListBox);
            this.Controls.Add(this.SelectObjectTypeLabel);
            this.Name = "ObjectSelection";
            this.Text = "ObjectSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectObjectTypeLabel;
        private System.Windows.Forms.ListBox ObjectTypeListBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}