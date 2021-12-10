using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.Models
{
    public class DocumentProcessModel
    {
        public int ID { get; set; }
        /// <summary>
        ///     Title of Document Process
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///    1=Active,0=Inactive (Method for 'deleting' DocumentProcesses)
        /// </summary>
        public Boolean IsActive { get; set; }
        /// <summary>
        /// Contains launch points associated with Document Process
        /// in Json format. e.g. [ {"LaunchPointID" : 1},{"LaunchPointID" : 2} ]
        /// </summary>
        public string LaunchPointInformation { get; set; }

        /// <summary>
        /// Contains access entities associated with Document Process
        /// in Json format. e.g. [ { "AccessEntityTypeID": 1, "AccessEntity" : "Engineering", "AccessTypeID" : 2},
        ///                        { "AccessEntityTypeID": 2, "AccessEntity" : "Marketing Manager", "AccessTypeID" : 3} ]
        /// </summary>
        public string AccessInformation { get; set; }

        /// <summary>
        /// Contains all the object information associated with a Document Process
        /// in Json format. e.g. [ { "ObjectType": 1, "Title" : "Note", "SortOrder" : 1},
        ///                        { "ObjectType": 2, "Title" : "Attachment", "SortOrder" : 1} ]
        /// </summary>
        public string ObjectInformation { get; set; }

        public string DisplayName
        {
            get
            {
                return $"{Title} ({ID})";
            }
        }
        public DocumentProcessModel()
        {

        }
        public DocumentProcessModel(string iD, string title, bool isActive,string accessInformation,string objectInformation,string launcPointInformation)
        {
            int iDValue = 0;
            int.TryParse(iD, out iDValue);
            ID = iDValue;

            Title = title;
            IsActive = isActive;
            AccessInformation = accessInformation;
            ObjectInformation = objectInformation;
            LaunchPointInformation = launcPointInformation;

        }
    }
}
