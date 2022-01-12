
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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentProcessEditor
{
    public partial class DocumentProcessEditor : Form
    {
        /// <summary>
        /// The currently selected DocumentProcessID
        /// </summary>
        private DocumentProcessModel SelectedDocumentProcess = new DocumentProcessModel();
        /// <summary>
      /// The current Launch Points that should appear in the Listbox
      /// </summary>
        private List<LaunchPointModel> LaunchPoints = new List<LaunchPointModel>();
       /// <summary>
       /// The current Access Entities that should appear in the Listbox
       /// </summary>
        private List<AccessRuleModel> AccessRules = new List<AccessRuleModel>();
        /// <summary>
        /// The current Document Process Objects that should appear in the Listbox
        /// </summary>
        private List<DocumentProcessObjectModel> DocumentProcessObjects = new List<DocumentProcessObjectModel>();

        private string searchText = "";

        private bool activeOnly = true;

        private bool changesMade = false;
        /// <summary>
        /// The index int the DocumentProcessListbox most recently selected
        /// </summary>
        private int currentDocumentProcessIndex = 1;


        /// <summary>
        /// signals whether the DocumentProcess ListBox is in the process of updating and there doesn't wnat the select change event to occur.
        /// </summary>
        private bool justSaved = false;
        /// <summary>
        /// If currentlySearching = false it will ignore the processes to run on select change event in Document Process List box
        /// </summary>
        private bool currentlySearching = false;

        public DocumentProcessEditor()
        {
            InitializeComponent();

            updateDocumentProcessListBox();
            DocumentProcessListBox.SelectedIndex = 0;
            updateRightHandSideFromDataConnection();

        }
        /// <summary>
        /// Resets listboxes with data from database
        /// </summary>
        private void updateRightHandSideFromDataConnection()
        {
            
            LaunchPoints = GlobalConfig.Connection.GetDocumentProcessLaunchPoints(SelectedDocumentProcess.ID);
            AccessRules = GlobalConfig.Connection.GetDocumentProcessAccessRules(SelectedDocumentProcess.ID);
            DocumentProcessObjects = GlobalConfig.Connection.GetDocumentProcessObjects(SelectedDocumentProcess.ID);

            updateLaunchPointsListBox();

            updateAccessRulesListBox();

            updateObjectListBox();
    
            if (SelectedDocumentProcess.ID == 0)
            {
                DocumentProcessNameTextBox.Text = "";
                SelectedDocumentProcessIDLabel.Text = "---";
            }
            else
            {
                DocumentProcessNameTextBox.Text = SelectedDocumentProcess.Title;
                SelectedDocumentProcessIDLabel.Text = SelectedDocumentProcess.ID.ToString();
                IsActiveCheckBox.Checked = SelectedDocumentProcess.IsActive;
            };
              
            
            DocumentProcessNameErrorMessage.Text = "";
            changesMade = false;
        }


        private void updateLaunchPointsListBox()
        {
            LaunchPointsListBox.DataSource = null;
            LaunchPointsListBox.DataSource = LaunchPoints;
            LaunchPointsListBox.DisplayMember = "DisplayName";
        }


        private void updateAccessRulesListBox()
        {
            AccessRulesListBox.DataSource = null;
            AccessRulesListBox.DataSource = AccessRules;
            AccessRulesListBox.DisplayMember = "DisplayName";
        }

        private void updateObjectListBox()
        {

            //records sort order and places into DocumentProcessobjects.
            for (int index = 0; index < DocumentProcessObjects.Count; index++)
            {
                DocumentProcessObjects[index].SortOrder = index + 1;
                DocumentProcessObjects[index].DocumentProcessID = SelectedDocumentProcess.ID;
            }

            ObjectListBox.DataSource = null;
            ObjectListBox.DataSource = DocumentProcessObjects;
            ObjectListBox.DisplayMember = "DisplayName";

        }


        /// <summary>
        /// Updates the Document Process List Box using text from Search box
        /// </summary>
        private void updateDocumentProcessListBox()
        {
            DocumentProcessListBox.DataSource = null;            
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

                SaveChanges();
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
            currentlySearching = true;
            updateDocumentProcessListBox();
            currentlySearching = false;
        }

        private void SearchTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            searchText = SearchTextbox.Text;
            currentlySearching = true;
            updateDocumentProcessListBox();
            currentlySearching = false;
        }

        private void SaveChanges()
        {
            var jsonAccessInformation = JsonSerializer.Serialize(AccessRules);
            var jsonLaunchPointInformation = JsonSerializer.Serialize(LaunchPoints);
            var jsonObjectsInformation = JsonSerializer.Serialize(DocumentProcessObjects);

            DocumentProcessModel model = new DocumentProcessModel(
                                                            SelectedDocumentProcessIDLabel.Text,
                                                            DocumentProcessNameTextBox.Text,
                                                            IsActiveCheckBox.Checked,
                                                            jsonAccessInformation,
                                                            jsonObjectsInformation,
                                                            jsonLaunchPointInformation
                                                            );

            if (SelectedDocumentProcessIDLabel.Text == "0") //New DocumentProcess
            {
                GlobalConfig.Connection.CreateDocumentProcess(model);
                MessageBox.Show("New Document Process Saved. " + model.ID + ": " + model.Title);
            }
            else
            {
                GlobalConfig.Connection.UpdateDocumentProcess(model);
                MessageBox.Show("Document Process Updated.");
            };

            changesMade = false;
            justSaved = true; //avoids updateDocumentProcessListBox getting confused by lots of different selection changes
            updateDocumentProcessListBox();
            justSaved = false;
        }

        private void DocumentProcessListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if ((DocumentProcessListBox.SelectedIndex != currentDocumentProcessIndex) & (justSaved== false) & (currentlySearching == false))//This avoids the function acting twice after SelectedIndex changed = currentDocumentProcessIndex in 'Yes' part of following If statement
            {
                if (changesMade)
                {
                    DialogResult userCheck = MessageBox.Show("Changes have been made! Do you wish to go back and save changes?", "Changes Check", MessageBoxButtons.YesNo);
                    if (userCheck == DialogResult.Yes)
                    {
                        DocumentProcessListBox.SelectedIndex = currentDocumentProcessIndex;
                       
                    }
                    else if (userCheck == DialogResult.No)
                    {
                        ChangeDocumentProcess();
                    }
                }
                else ChangeDocumentProcess();         
            }

        }

        private void ChangeDocumentProcess()
        {
               SelectedDocumentProcess = (DocumentProcessModel)DocumentProcessListBox.SelectedItem;
               currentDocumentProcessIndex = DocumentProcessListBox.SelectedIndex;
                        
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
            
           
            foreach (LaunchPointModel lp in childForm.SelectedLaunchPoints)
            {
                if (!LaunchPoints.Exists(x => x.ID == lp.ID)) 
                {
                    LaunchPoints.Add(lp);
                }
            }
           

            updateLaunchPointsListBox();

            changesMade = true;
        }

        private void RemoveLaunchPointButton_Click(object sender, EventArgs e)
        {
            LaunchPointModel selectedLaunchPoint = (LaunchPointModel)LaunchPointsListBox.SelectedItem;

            LaunchPoints.Remove(selectedLaunchPoint);

            updateLaunchPointsListBox();

            changesMade = true;
        }

        private void AddAccessEntityButton_Click(object sender, EventArgs e)
        {
            AccessSetup childForm = new AccessSetup();
            childForm.ShowDialog();

            if (!(string.IsNullOrEmpty(childForm.SelectedAccessType.Title)))
            {
            //  This section is needed as couldn't great a parametised constructor for AccessRuleModel as Dapper didn't like it when getting accessrulemodel from sql
            AccessRuleModel newAccessRule = new AccessRuleModel();
            newAccessRule.AccessTypeID = childForm.SelectedAccessType.ID;
            newAccessRule.AccessTypeTitle = childForm.SelectedAccessType.Title;
            newAccessRule.AccessEntityTypeID = childForm.SelectedAccessEntityType.ID;
            newAccessRule.AccessEntityTypeTitle = childForm.SelectedAccessEntityType.Title;
            newAccessRule.AccessEntityID = childForm.SelectedAccessEntity.ID;
            newAccessRule.AccessEntityName = childForm.SelectedAccessEntity.Name;

            AccessRules.Add(newAccessRule);

            updateAccessRulesListBox();
            
            changesMade = true;
            }
            
            
        
        }

        private void RemoveAccessEntityButton_Click(object sender, EventArgs e)
        {
            AccessRuleModel selectedAccessRule = (AccessRuleModel)AccessRulesListBox.SelectedItem;

            AccessRules.Remove(selectedAccessRule);

            updateAccessRulesListBox();

            changesMade = true;
        }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            ObjectSelection childForm = new ObjectSelection();
            childForm.ShowDialog();



            if (!(childForm.NewObject ==  null)) //should indicate that an object has been filled
            {
                
                //  This section is needed as couldn't great a parametised constructor for AccessRuleModel as Dapper didn't like it when getting accessrulemodel from sql
                DocumentProcessObjectModel model = new DocumentProcessObjectModel();
                model.Title = childForm.NewObject.Title;
                model.ObjectTypeID = childForm.NewObject.ObjectTypeID;
                model.ObjectTypeName = childForm.NewObject.ObjectTypeTitle;
                model.Information = childForm.NewObject.Information;

                DocumentProcessObjects.Add(model);
            }

            updateObjectListBox();

            changesMade = true;
        }



        ////Code to change sort order of ObjectsListBox using Drag and Drop
        //private void ObjectListBox_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Point mousePoint = ObjectListBox.PointToClient(new Point(e.X, e.Y));
        //    int dragFromIndex = ObjectListBox.IndexFromPoint(mousePoint);
        //    if (dragFromIndex < 0) return;
            
        //    ObjectListBox.DoDragDrop(ObjectListBox.Items[dragFromIndex], DragDropEffects.Move);
        //}

        //private void ObjectListBox_DragOver(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Move;
        //}

        //private void ObjectListBox_DragDrop(object sender, DragEventArgs e)
        //{
        //    Point mousePoint = ObjectListBox.PointToClient(new Point(e.X, e.Y));
        //    int dragToIndex = ObjectListBox.IndexFromPoint(mousePoint);
        //    if (dragToIndex < 0) dragToIndex = ObjectListBox.Items.Count - 1; //if item has been dragged below last member of list then put it at the bottom
        //    Object draggedObject = e.Data.GetData(typeof(DocumentProcessObjectModel));
        //    ObjectListBox.Items.Remove(draggedObject);
        //    ObjectListBox.Items.Insert(dragToIndex, draggedObject);

        //    changesMade = true;
        //}

        private void RemoveObjectButton_Click(object sender, EventArgs e)
        {
            DocumentProcessObjectModel selectedObject = (DocumentProcessObjectModel)ObjectListBox.SelectedItem;

            DocumentProcessObjects.Remove(selectedObject);

            updateObjectListBox();

            changesMade = true;
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            DocumentProcessObjectModel selectedObject = (DocumentProcessObjectModel)ObjectListBox.SelectedItem;

            int indexTo = ObjectListBox.SelectedIndex - 1;

            if (indexTo < 0) return;//top of list

            DocumentProcessObjects.Remove(selectedObject);
            DocumentProcessObjects.Insert(indexTo, selectedObject);

            updateObjectListBox();

            ObjectListBox.SelectedIndex = indexTo;

            changesMade = true;
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            DocumentProcessObjectModel selectedObject = (DocumentProcessObjectModel)ObjectListBox.SelectedItem;
            

            int indexTo = ObjectListBox.SelectedIndex + 1;

            if (indexTo > ObjectListBox.Items.Count - 1) return;//bottom of list

            DocumentProcessObjects.Remove(selectedObject);
            DocumentProcessObjects.Insert(indexTo, selectedObject);

            updateObjectListBox();

            ObjectListBox.SelectedIndex = indexTo;

            changesMade = true;
        }

        private void EditObjectButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException(); //TODO Editing of document process- needs to reuse code within Object Selection Form
        }
    }
}
