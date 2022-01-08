using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.Models
{
    public class AccessEntityTypeModel
    {
        /// <summary>
        /// ID of the AccessEntityType: 1=Report Group,2=Job Title,3=Employee,4=UserConnectingFieldID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name of AccessEntityType
        /// </summary>
        public string Title { get; set; }
    }
}
