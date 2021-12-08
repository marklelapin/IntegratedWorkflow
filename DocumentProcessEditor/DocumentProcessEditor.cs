
using IntegratedWorkflowLibrary;
using IntegratedWorkflowLibrary.DataAccess;
using IntegratedWorkflowLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentProcessEditor
{
    public partial class DocumentProcessEditor : Form
    {
        public DocumentProcessEditor()
        {
            InitializeComponent();
        }
        
        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            SelectedDocumentProcessID.Text = "New";
            DocumentProcessNameTextBox.Text = "Enter Name";
            IsActiveCheckBox.Checked = true;

            //TODO - update objects list box to nothing (if update of binding doesn't clear it)
            List<string> MyObjectsList = new List<string>();
            MyObjectsList.Add("Update Objects Associated With "+SelectedDocumentProcessID.Text);
            ObjectListBox.DataSource = MyObjectsList;

            //TODO - update access list bo box to nothing (if update of binding doesn't clear it)
            List<string> MyAccessList = new List<string>();
            MyAccessList.Add("Update Access Entities Associated With " + SelectedDocumentProcessID.Text);
            AccessListBox.DataSource = MyAccessList;

            //TODO - update launchpoints list box to nothing (if update of binding doesn't clear it)
            List<string> MyLPList = new List<string>();
            MyLPList.Add("Update LaunchPoints Associated With " + SelectedDocumentProcessID.Text);
            LaunchPointsListBox.DataSource = MyLPList;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                DocumentProcessNameErrorMessage.Visible = false;
                DocumentProcessNameErrorMessage.Text = "";

                

                DocumentProcessModel model = new DocumentProcessModel(
                                                                    SelectedDocumentProcessID.Text,
                                                                    DocumentProcessNameTextBox.Text,
                                                                    IsActiveCheckBox.Checked,
                                                                    "",//TODO - add in access information from acces listbox
                                                                    "",//TODO - add in object json from object listbox
                                                                    ""//TODO - add in launchpoint info from lp listbox
                                                                    );

                GlobalConfig.Connection.CreateDocumentProcess(model);               {
                   
                }


                MessageBox.Show("New Document Process Saved. "+model.ID + ": "+ model.Title);
                
                //Clear the selected Document Process section of 
                IsActiveCheckBox.Checked = false;
                ObjectListBox.DataSource = null;
                AccessListBox.DataSource = null;
                LaunchPointsListBox.DataSource = null;
                SelectedDocumentProcessID.Text = "---";
                DocumentProcessNameTextBox.Text = "";
                
                //TODO - deselect document process list
            }
            else
            {
                MessageBox.Show("Errors Exists - Changes weren't saved.");
            }
            ;

            bool ValidateForm()
            {
                bool output = true;

                if (DocumentProcessNameTextBox.TextLength == 0)
                {
                    DocumentProcessNameErrorMessage.Text = "Name can't be blank!";
                    output = false;
                };

                if (DocumentProcessNameTextBox.Text == "Enter Name")
                {
                    DocumentProcessNameErrorMessage.Text = "You need to enter a new name!";
                    DocumentProcessNameErrorMessage.Visible = true;
                    output = false;
                };

                return output;
            }

        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            //TODO -- update documentprocess listbox
        }
    }
}
