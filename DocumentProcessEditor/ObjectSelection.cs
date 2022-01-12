using IntegratedWorkflowLibrary;
using IntegratedWorkflowLibrary.Models;
using IntegratedWorkflowLibrary.Models.ObjectSetup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace DocumentProcessEditor
{
    public partial class ObjectSelection : Form
    {
        public GeneralObjectSetupModel NewObject;

        public ObjectSelection()
        {
            InitializeComponent();
            populateObjectTypeListBox();
        }

        private void populateObjectTypeListBox()
        {
            ObjectTypeListBox.DataSource = GlobalConfig.Connection.GetObjectTypes();
            ObjectTypeListBox.DisplayMember = "Title";
        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            ObjectTypeModel selectedObjectTypeModel = (ObjectTypeModel)ObjectTypeListBox.SelectedItem;

            int objectTypeID = selectedObjectTypeModel.ID;
            string objectTypeTitle = selectedObjectTypeModel.Title;

            switch (objectTypeID)
            {
                case 1: //FreeText
                   
                    FreeTextObjectSetup childForm = new FreeTextObjectSetup();
                    
                    // the code below just needs to be repeated for each form below
                    childForm.ShowDialog();
                    NewObject = new GeneralObjectSetupModel(childForm.outputModel.Title
                                                            , objectTypeID
                                                            , objectTypeTitle
                                                            ,JsonSerializer.Serialize(childForm.outputModel));
                    break;

                case 2: //Attachment
                    throw new NotImplementedException();
                    break;

                case 3: //Date
                    throw new NotImplementedException();
                    break;

                case 4: //Category
                    throw new NotImplementedException();
                    break;

                case 5: //Number
                    throw new NotImplementedException();
                    break;

                case 6: //YesNo
                    throw new NotImplementedException();
                    break;

                case 7: //DataDrivenCategory
                    throw new NotImplementedException();
                    break;

                case 8: //Approval
                    throw new NotImplementedException();
                    break;

            }

            this.Hide();
    
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}