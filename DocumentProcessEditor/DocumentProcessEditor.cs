
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
        public int documentProcessID = 0;
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
            updateListBoxesFromDataConnection();

        }
        /// <summary>
        /// Resets listboxes with data from database
        /// </summary>
        private void updateListBoxesFromDataConnection()
        {
            LaunchPoints = GlobalConfig.Connection.GetDocumentProcessLaunchPoints(documentProcessID); //TODO add DocumentProcessID from selected document Process
            AccessEntities = GlobalConfig.Connection.GetDocumentProcessAccessEntities(documentProcessID);
            DocumentProcessObjects = GlobalConfig.Connection.GetDocumentProcessObjects(documentProcessID);

            LaunchPointsListBox.DataSource = LaunchPoints;
            LaunchPointsListBox.DisplayMember = "Title";
                            
            AccessListBox.DataSource = AccessEntities;
            AccessListBox.DisplayMember = "DisplayName";

            ObjectListBox.DataSource = DocumentProcessObjects;
            ObjectListBox.DisplayMember= "DisplayName";
        }

        /// <summary>
        /// Updates the Document Process List Box using text from Search box
        /// </summary>
        private void updateDocumentProcessListBox()
        {
            DocumentProcessListBox.DataSource = GlobalConfig.Connection.SearchDocumentProcesses(searchText, activeOnly);
            DocumentProcessListBox.DisplayMember = "DisplayName";
        }
        private void updateListboxes()
        {
     
            ObjectListBox.DataSource = LaunchPoints;

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

            updateDocumentProcessListBox();
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

        //TODO - public void AddLaunchPointButton_Click(object sender, EventArgs e)
        //{
        //    //LaunchPointSetup form = new LaunchPointSetup();
        //    //AddedLaunchPoints = new List<LaunchPointModel>(); //this will be used to pass parameters back in.
        //    //form.Show();
        //    //LaunchPoints.AddRange(AddedLaunchPoints);
            
            

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
    }
}
