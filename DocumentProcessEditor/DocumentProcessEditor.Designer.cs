
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
            this.DocumentProcessListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ObjectListBox = new System.Windows.Forms.ListBox();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.Objects = new System.Windows.Forms.Label();
            this.SeachLabel = new System.Windows.Forms.Label();
            this.AccessLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AccessListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CreateAccessEntity = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocumentProcessListBox
            // 
            this.DocumentProcessListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DocumentProcessListBox.FormattingEnabled = true;
            this.DocumentProcessListBox.ItemHeight = 17;
            this.DocumentProcessListBox.Location = new System.Drawing.Point(12, 74);
            this.DocumentProcessListBox.Name = "DocumentProcessListBox";
            this.DocumentProcessListBox.Size = new System.Drawing.Size(281, 378);
            this.DocumentProcessListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document Processes";
            // 
            // ObjectListBox
            // 
            this.ObjectListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ObjectListBox.FormattingEnabled = true;
            this.ObjectListBox.ItemHeight = 17;
            this.ObjectListBox.Location = new System.Drawing.Point(6, 46);
            this.ObjectListBox.Name = "ObjectListBox";
            this.ObjectListBox.Size = new System.Drawing.Size(266, 359);
            this.ObjectListBox.TabIndex = 2;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(74, 41);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(219, 27);
            this.SearchTextbox.TabIndex = 4;
            // 
            // Objects
            // 
            this.Objects.AutoSize = true;
            this.Objects.Location = new System.Drawing.Point(6, 23);
            this.Objects.Name = "Objects";
            this.Objects.Size = new System.Drawing.Size(59, 20);
            this.Objects.TabIndex = 7;
            this.Objects.Text = "Objects";
            // 
            // SeachLabel
            // 
            this.SeachLabel.AutoSize = true;
            this.SeachLabel.Location = new System.Drawing.Point(12, 44);
            this.SeachLabel.Name = "SeachLabel";
            this.SeachLabel.Size = new System.Drawing.Size(56, 20);
            this.SeachLabel.TabIndex = 8;
            this.SeachLabel.Text = "Search:";
            // 
            // AccessLabel
            // 
            this.AccessLabel.AutoSize = true;
            this.AccessLabel.Location = new System.Drawing.Point(306, 23);
            this.AccessLabel.Name = "AccessLabel";
            this.AccessLabel.Size = new System.Drawing.Size(53, 20);
            this.AccessLabel.TabIndex = 9;
            this.AccessLabel.Text = "Access";
            this.AccessLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.CreateAccessEntity);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AccessListBox);
            this.groupBox1.Controls.Add(this.Objects);
            this.groupBox1.Controls.Add(this.AccessLabel);
            this.groupBox1.Controls.Add(this.ObjectListBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(309, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Document Process";
            // 
            // AccessListBox
            // 
            this.AccessListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessListBox.FormattingEnabled = true;
            this.AccessListBox.ItemHeight = 17;
            this.AccessListBox.Location = new System.Drawing.Point(306, 47);
            this.AccessListBox.Name = "AccessListBox";
            this.AccessListBox.Size = new System.Drawing.Size(266, 293);
            this.AccessListBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(203, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 25);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CreateAccessEntity
            // 
            this.CreateAccessEntity.BackColor = System.Drawing.Color.White;
            this.CreateAccessEntity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateAccessEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccessEntity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateAccessEntity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateAccessEntity.Location = new System.Drawing.Point(503, 18);
            this.CreateAccessEntity.Name = "CreateAccessEntity";
            this.CreateAccessEntity.Size = new System.Drawing.Size(69, 25);
            this.CreateAccessEntity.TabIndex = 14;
            this.CreateAccessEntity.Text = "Add New";
            this.CreateAccessEntity.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(342, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 25);
            this.button3.TabIndex = 16;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(450, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel Changes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // DocumentProcessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 484);
            this.Controls.Add(this.SeachLabel);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocumentProcessListBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DocumentProcessEditor";
            this.Text = "DocumentProcessEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DocumentProcessListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ObjectListBox;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Label Objects;
        private System.Windows.Forms.Label SeachLabel;
        private System.Windows.Forms.Label AccessLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button CreateAccessEntity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox AccessListBox;
    }
}

