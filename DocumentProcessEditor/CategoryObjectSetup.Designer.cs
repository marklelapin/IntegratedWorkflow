
namespace DocumentProcessEditor
{
    partial class CategoryObjectSetup
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
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.ReNameCategoryButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryListLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCategoryTextBox = new System.Windows.Forms.TextBox();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.SelectedCategoryLabel = new System.Windows.Forms.Label();
            this.NewCategoryLabel = new System.Windows.Forms.Label();
            this.NewCategoryTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 15;
            this.CategoryListBox.Location = new System.Drawing.Point(22, 79);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(213, 364);
            this.CategoryListBox.TabIndex = 0;
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.BackColor = System.Drawing.Color.White;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddCategoryButton.Location = new System.Drawing.Point(328, 325);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(74, 29);
            this.AddCategoryButton.TabIndex = 1;
            this.AddCategoryButton.Text = "Add";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            // 
            // ReNameCategoryButton
            // 
            this.ReNameCategoryButton.BackColor = System.Drawing.Color.White;
            this.ReNameCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReNameCategoryButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReNameCategoryButton.Location = new System.Drawing.Point(377, 204);
            this.ReNameCategoryButton.Name = "ReNameCategoryButton";
            this.ReNameCategoryButton.Size = new System.Drawing.Size(74, 29);
            this.ReNameCategoryButton.TabIndex = 2;
            this.ReNameCategoryButton.Text = "ReName";
            this.ReNameCategoryButton.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(22, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 21);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CategoryListLabel
            // 
            this.CategoryListLabel.AutoSize = true;
            this.CategoryListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryListLabel.Location = new System.Drawing.Point(22, 55);
            this.CategoryListLabel.Name = "CategoryListLabel";
            this.CategoryListLabel.Size = new System.Drawing.Size(104, 21);
            this.CategoryListLabel.TabIndex = 5;
            this.CategoryListLabel.Text = "Category List:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(67, 14);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(406, 23);
            this.TitleTextBox.TabIndex = 6;
            // 
            // SelectedCategoryTextBox
            // 
            this.SelectedCategoryTextBox.Location = new System.Drawing.Point(257, 175);
            this.SelectedCategoryTextBox.Name = "SelectedCategoryTextBox";
            this.SelectedCategoryTextBox.Size = new System.Drawing.Size(216, 23);
            this.SelectedCategoryTextBox.TabIndex = 8;
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.BackColor = System.Drawing.Color.White;
            this.DeleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCategoryButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteCategoryButton.Location = new System.Drawing.Point(281, 204);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(74, 29);
            this.DeleteCategoryButton.TabIndex = 9;
            this.DeleteCategoryButton.Text = "Delete";
            this.DeleteCategoryButton.UseVisualStyleBackColor = false;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectedCategoryLabel
            // 
            this.SelectedCategoryLabel.AutoSize = true;
            this.SelectedCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedCategoryLabel.Location = new System.Drawing.Point(257, 142);
            this.SelectedCategoryLabel.Name = "SelectedCategoryLabel";
            this.SelectedCategoryLabel.Size = new System.Drawing.Size(135, 21);
            this.SelectedCategoryLabel.TabIndex = 10;
            this.SelectedCategoryLabel.Text = "Selected Category";
            // 
            // NewCategoryLabel
            // 
            this.NewCategoryLabel.AutoSize = true;
            this.NewCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewCategoryLabel.Location = new System.Drawing.Point(257, 265);
            this.NewCategoryLabel.Name = "NewCategoryLabel";
            this.NewCategoryLabel.Size = new System.Drawing.Size(109, 21);
            this.NewCategoryLabel.TabIndex = 11;
            this.NewCategoryLabel.Text = "New Category";
            // 
            // NewCategoryTextBox
            // 
            this.NewCategoryTextBox.Location = new System.Drawing.Point(257, 296);
            this.NewCategoryTextBox.Name = "NewCategoryTextBox";
            this.NewCategoryTextBox.Size = new System.Drawing.Size(216, 23);
            this.NewCategoryTextBox.TabIndex = 12;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.White;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveButton.Location = new System.Drawing.Point(172, 453);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 29);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CancelButton.Location = new System.Drawing.Point(270, 453);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 29);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // CategoryObjectSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 494);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewCategoryTextBox);
            this.Controls.Add(this.NewCategoryLabel);
            this.Controls.Add(this.SelectedCategoryLabel);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.SelectedCategoryTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CategoryListLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ReNameCategoryButton);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CategoryListBox);
            this.Name = "CategoryObjectSetup";
            this.Text = "CategoryObjectSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Button ReNameCategoryButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryListLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox SelectedCategoryTextBox;
        private System.Windows.Forms.Button DeleteCategoryButton;
        private System.Windows.Forms.Label SelectedCategoryLabel;
        private System.Windows.Forms.Label NewCategoryLabel;
        private System.Windows.Forms.TextBox NewCategoryTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}