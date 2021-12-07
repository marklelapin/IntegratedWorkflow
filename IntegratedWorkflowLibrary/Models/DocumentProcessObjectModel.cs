using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.Models
{
    public class DocumentProcessObjectModel
    {

        public int ID { get; set; }

        /// <summary>
        /// DocumentProcess that this object relates to
        /// </summary>
        public int DocumentProcessID { get; set; }
        /// <summary>
        /// the Type of Object it is i.e Date Field, Category Field, Email, Text, Yes/No
        /// </summary>
        public int DocumentProcessObjectTypeID { get; set; }
        /// <summary>
        /// Name of the Object that will appear on forms etc
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Order in which the object will appear in a list of objects for this DocumentProcess
        /// </summary>
        public int SortOrder { get; set; }
        /// <summary>
        /// Json formatted text of additional data
        /// </summary>
        public string Information { get; set; }
    }
}