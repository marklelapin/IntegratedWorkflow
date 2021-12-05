using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorklowLibrary.Models

{
    public class DocumentProcessModel
    {
        public int ID { get; set; }
        /// <summary>
        ///     Title of Document Process
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///    1=Active,0=Inactive (Method for deleting DocumentProcesses)
        /// </summary>
        public Boolean IsActive { get; set; }

        public DocumentProcessModel()
        {

        }
        public DocumentProcessModel(string iD, string title, bool isActive)
        {
            int iDValue = 0;
            int.TryParse(iD, out iDValue);
            ID = iDValue;

            Title = title;

            IsActive = isActive;

        }
    }
}
