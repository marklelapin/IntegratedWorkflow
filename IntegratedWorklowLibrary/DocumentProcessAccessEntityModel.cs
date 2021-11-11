using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorklowLibrary
{
    public class DocumentProcessAccessEntityModel
    {
        public int ID { get; set; }
        /// <summary>
        ///     The Document Process this access entity is related to.
        /// </summary>
        public int DocumentProcessID { get; set; }
        /// <summary>
        ///     The Access Entity Type determining how tfnDocumentAccess will calculate access
        ///     1-Report Group,1-Job Title,3-Employee,4-UserConnectingFieldID
        /// </summary>
        public int AccessEntityTypeID { get; set; }
        /// <summary>
        /// Identifies the particular group, person or job title etc to determine access from
        /// </summary>
        public string AccessEntity { get; set; }
        /// <summary>
        /// Determines the amount of access to be given.
        /// 1. Upwards Only View, 2.	Upwards Only Edit, 3. Match or Upwards View,
        /// 4. Match or Upwards Edit, 5. Downwards View, 6.Downwards Edit,7. Admin
        /// </summary>
        public int AccessTypeID { get; set; }
    }
}
