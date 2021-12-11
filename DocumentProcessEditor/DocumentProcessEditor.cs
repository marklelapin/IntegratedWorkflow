
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
        /// <summary>
        /// The currently selected DocumentProcessID
        /// </summary>
        public DocumentProcessModel SelectedDocumentProcess = new DocumentProcessModel();
        /// <summary>
      /// The current Launch Points that should appear in the Listbox
      /// </summary>
        private List<LaunchPointModel> LaunchPoints = new List<LaunchPointModel>();
       /// <summary>
       /// The current Access Entities that should appear in the Listbox
       /// </summary>
        private List<AccessEntityModel> AccessEntities = new List<AccessEntityModel>();
        /// <summary>
        /// The current Document Process Objects that should appear in the Listbox
        /// </summary>
        private List<DocumentProcessObjectModel> DocumentProcessObjects = new List<DocumentProcessObjectModel>();

        private string searchText = "";

        private bool activeOnly = true;
       

        

        public DocumentProcessEditor()
        {
            InitializeComponent();

            updateDocumentProcessListBox();
            updateRightHandSideFromDataConnection();

        }
        /// <summary>
        /// Resets listboxes with data from database
        /// </summary>
        private void updateRightHandSideFromDataConnection()
        {
            LaunchPoints = GlobalConfig.Connection.GetDocumentProcessLaunchPoints(SelectedDocumentProcess.ID);
            AccessEntities = GlobalConfig.Connection.GetDocumentProcessAccessEntities(SelectedDocumentProcess.ID);
            DocumentProcessObjects = GlobalConfig.Connection.GetDocumentProcessObjects(SelectedDocumentProcess.ID);

            updateLaunchPointsListBox();

            updateAccessListBox();

            updateObjectListBox();

            SelectedDocumentProcessIDLabel.Text = SelectedDocumentProcess.ID.ToString();
            DocumentProcessNameTextBox.Text = SelectedDocumentProcess.Title;
            IsActiveCheckBox.Checked = SelectedDocumentProcess.IsActive;
            DocumentProcessNameErrorMessage.Text = "";
        }


        private void updateLaunchPointsListBox()
        {
            LaunchPointsListBox.DataSource = null;
            LaunchPointsListBox.DataSource = LaunchPoints;
            LaunchPointsListBox.DisplayMember = "Title";
        }


        private void updateAccessListBox()
        {
            AccessListBox.DataSource = null;
            AccessListBox.DataSource = AccessEntities;
            AccessListBox.DisplayMember = "DisplayName";
        }

        private void updateObjectListBox()
        {
            ObjectListBox.DataSource = null;
            ObjectListBox.DataSource = DocumentProcessObjects;
            ObjectListBox.DisplayMember = "DisplayName";
        }


        /// <summary>
        /// Updates the Document Process List Box using text from Search box
        /// </summary>
        private void updateDocumentProcessListBox()
        {
            DocumentProcessListBox.DataSource = GlobalConfig.Connection.SearchDocumentProcesses(searchText, activeOnly);
            DocumentProcessListBox.DisplayMember = "DisplayName";
        }
       

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
            SelectedDocumentProcess = new DocumentProcessModel();
            updateRightHandSideFromDataConnection();   
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                DocumentProcessNameErrorMessage.Visible = false;
                DocumentProcessNameErrorMessage.Text = "";

                

                DocumentProcessModel model = new DocumentProcessModel(
                                                                    SelectedDocumentProcessIDLabel.Text,
                                                                    DocumentProcessNameTextBox.Text,
                                                                    IsActiveCheckBox.Checked,
                                                                    "",//TODO - add in access information from acces listbox
                                                                    "",//TODO - add in object json from object listbox
                                                                    ""//TODO - add in launchpoint info from lp listbox
                                                                    );

                GlobalConfig.Connection.CreateDocumentProcess(model);               {
                   
                }


                MessageBox.Show("New Document Process Saved. "+model.ID + ": "+ model.Title);
                
                updateDocumentProcessListBox();
            }
            else
            {
                MessageBox.Show("Errors Exists - Changes weren't saved.");
            }
            ;

            bool ValidateForm()
            {
                return ValidateName();
            }

        }

             
            
        private bool ValidateName()
        {
            bool output = true;

            if (DocumentProcessNameTextBox.TextLength == 0)
            {
                DocumentProcessNameErrorMessage.Text = "Name can't be blank";
                output = false;
            };

            if (DocumentProcessNameTextBox.Text == "Enter Name")
            {
                DocumentProcessNameErrorMessage.Text = "You need to enter a new name!";
                output = false;
            };

            if (output == true)
            {
                DocumentProcessNameErrorMessage.Text = "";
            }
            return output;
        }
        //}

        private void ActiveOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            activeOnly = ActiveOnlyCheckBox.Checked;
            updateDocumentProcessListBox();
        }

        private void SearchTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            searchText = SearchTextbox.Text;
            updateDocumentProcessListBox();
        }

        private void DocumentProcessListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDocumentProcess = (DocumentProcessModel)DocumentProcessListBox.SelectedItem;
            DocumentProcessNameTextBox.Text = SelectedDocumentProcess.Title;
            SelectedDocumentProcessIDLabel.Text = SelectedDocumentProcess.ID.ToString();
            updateRightHandSideFromDataConnection();
        }

        private void DocumentProcessNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateName();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            updateRightHandSideFromDataConnection();
        }

        private void AddLaunchPointButton_Click(object sender, EventArgs e)
        {
            LaunchPointSetup childForm = new LaunchPointSetup();
            childForm.ShowDialog();
                            
            LaunchPoints.AddRange(childForm.SelectedLaunchPoints);

            updateLaunchPointsListBox();

        }

        private void RemoveLaunchPointButton_Click(object sender, EventArgs e)
        {
            LaunchPointModel selectedLaunchPoint = (LaunchPointModel)LaunchPointsListBox.SelectedItem;

            LaunchPoints.Remove(selectedLaunchPoint);

            updateLaunchPointsListBox();
        }
    }
}
