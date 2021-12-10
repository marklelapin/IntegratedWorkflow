using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.Models
{
    public class AccessTypeModel
    {
        /// <summary>
        /// Access Type ID from database
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Descripiton of Access Type
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Determines whether user can view document
        /// </summary>
        public bool AllowView { get; set; }
        /// <summary>
        /// Determines whether user can edit Document
        /// </summary>
        public bool AllowEdit { get; set; }
        /// <summary>
        /// Determines whether users below the given access entity can access the document
        /// </summary>
        public bool AllowDownwards { get; set; }
        /// <summary>
        /// Determines whether user matching the given access entity can access the document
        /// </summary>
        public bool AllowMatch { get; set; }
    }
}
