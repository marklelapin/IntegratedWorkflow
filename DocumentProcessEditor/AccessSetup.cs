using IntegratedWorkflowLibrary;
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
    public partial class AccessSetup : Form
    {
        /// <summary>
        /// The selected AccessType from AccessSetup form.
        /// </summary>
        public AccessTypeModel SelectedAccessType;
        /// <summary>
        /// The selected AccessEntity from AccessSetup form.
        /// </summary>
        public AccessEntityModel SelectedAccessEntity;
        /// <summary>
        /// The selected AccessEntityType from AccessSetup form.
        /// </summary>
        public AccessEntityTypeModel SelectedAccessEntityType;

        public AccessSetup()
        {
            InitializeComponent();

            populateAccessTypeComboBox();
            populateAccessEntityTypeComboBox();
        }

        private void populateAccessTypeComboBox ()
        {
            AccessTypeComboBox.DataSource = GlobalConfig.Connection.GetAccessTypes();
            AccessTypeComboBox.DisplayMember = "Title";       
        }

        private void populateAccessEntityTypeComboBox()
        {
            AccessEntityTypeComboBox.DataSource = GlobalConfig.Connection.GetAccessEntityTypes();
            AccessEntityTypeComboBox.DisplayMember = "Title";
        }

        private void populateAccessEntityComboBox()
        {
            AccessEntityComboBox.DataSource = GlobalConfig.Connection.GetAccessEntities(SelectedAccessEntityType.ID);
            AccessEntityComboBox.DisplayMember = "Name";
        }


        private void AccessEntityTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAccessEntityType = (AccessEntityTypeModel)AccessEntityTypeComboBox.SelectedItem;
            populateAccessEntityComboBox();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            var valid = true;

            if ((AccessEntityComboBox.SelectedIndex == -1)
                || (AccessEntityTypeComboBox.SelectedIndex == -1)
                || (AccessTypeComboBox.SelectedIndex == -1))
            {
                valid = false;
            }

            if (valid)
            {
                SelectedAccessType = (AccessTypeModel)AccessTypeComboBox.SelectedItem;
                SelectedAccessEntityType = (AccessEntityTypeModel)AccessEntityTypeComboBox.SelectedItem;
                SelectedAccessEntity = (AccessEntityModel)AccessEntityComboBox.SelectedItem;

                this.Hide();
            }
            else
            {
                MessageBox.Show("Not enough information provided.");
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
