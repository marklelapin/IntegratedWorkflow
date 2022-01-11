using IntegratedWorkflowLibrary.Models;
using IntegratedWorkflowLibrary.Models.ObjectSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentProcessEditor
{
    public partial class FreeTextObjectSetup : Form
    {
        /// <summary>
        /// Integer value from MaxLengthTextBox
        /// </summary>
        private int maxLength;

        public FreeTextSetupModel outputModel;

        public FreeTextObjectSetup()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (validateForm())
            {
               outputModel = new FreeTextSetupModel(title: TitleTextBox.Text
                                                                        , maxLength: maxLength
                                                                        , isOptional: IsOptionalCheckBox.Checked);
                
                this.Hide();
            }





            bool validateForm()
                {
                bool output = true;

                //test for max length integer
                output = int.TryParse(MaxLengthTextBox.Text, out maxLength);
                if (output == false)
                {
                    MessageBox.Show("Max Length must be an integer");
                }

                //test for nonblank title
                 if (TitleTextBox.Text.Length == 0)
                    {
                    MessageBox.Show("Title / Question cannot be blank!");

                    output = false; }
              
                return output;         

                }
       


        }
        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
