using IntegratedWorkflowLibrary;
using IntegratedWorkflowLibrary.DataAccess;
using IntegratedWorkflowLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DocumentProcessEditor
{
    public partial class LaunchPointSetup : Form
    {
        //private List<LaunchPointModel> launchPoints = GlobalConfig.Connection.GetLaunchPoints();

       

        public LaunchPointSetup()
        {
            InitializeComponent();

            PopulateList();
        }

       
        private void PopulateList()
        {
            LaunchPointListBox.DataSource = GlobalConfig.Connection.GetLaunchPoints();
            LaunchPointListBox.DisplayMember = "Title";
        }

       
        private void CreateButton_Click(object sender, EventArgs e)
        {
           if (ValidateLaunchPointCreation())
            {
                LaunchPointModel model = new LaunchPointModel(0, CreateTextBox.Text, true);
                GlobalConfig.Connection.CreateLaunchPoint(model);
                PopulateList();
            }
            
        }

        


        private bool ValidateLaunchPointCreation()
        {
            bool validation = true;

            if (CreateTextBox.TextLength.Equals(0))
                {
                MessageBox.Show("You must enter a name for the new Launch Point in the Text Box Above");
                validation = false;
                }


            //TODO - Validation of text already being in launch point launchPoints.Find(r => r.Title == CreateTextBox.Text);

            //if ()


            //    myList.Where(item => item.Name == nameToExtract)

            return validation;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
