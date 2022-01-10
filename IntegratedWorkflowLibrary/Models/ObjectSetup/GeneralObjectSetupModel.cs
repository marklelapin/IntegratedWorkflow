using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.Models.ObjectSetup
{
    public class GeneralObjectSetupModel
    {
        /// <summary>
        /// Object Type ID
        /// </summary>
        public int ObjectTypeID;

        /// <summary>
        /// Name of Object Type
        /// </summary>
        public string ObjectTypeTitle;

        /// <summary>
        /// Name of Object
        /// </summary>
        public string Title;

        /// <summary>
        /// json Description of all properties associated with Object Setup
        /// </summary>
        public string Information;

        /// <summary>
        /// Constructs a Generalised Object Setup model from FreeText,YesNo,Category Object Setup Models etc
        /// </summary>
        /// <param name="title">
        /// Name of Object
        /// </param>
        /// <param name="objectTypeID">
        /// Object Type ID
        /// </param>
        /// <param name="information">
        /// json Description of all properties associated with Object Setup
        /// </param>
        public GeneralObjectSetupModel(string title, int objectTypeID, string objectTypeTitle, string information)
        {
            Title = title;
            ObjectTypeID = objectTypeID;
            ObjectTypeTitle = objectTypeTitle;
            Information = information;
        }
    }
}
