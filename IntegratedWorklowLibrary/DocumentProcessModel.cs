using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorklowLibrary
{
    public class DocumentProcessModel
    {
        public int ID { get; set; }
        /// <summary>
        ///    The type of Document Process i.e. action, email, text etc select * from dbo.DocumentProcess
        /// </summary>
        public int DocumentProcessTypeID { get; set; }
        /// <summary>
        ///     Title of Document Process
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///    1=Active,0=Inactive (Method for deleting DocumentProcesses)
        /// </summary>
        public Boolean IsActive { get; set; }
    }
}
