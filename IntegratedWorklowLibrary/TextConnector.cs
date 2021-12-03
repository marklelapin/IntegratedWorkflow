using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorklowLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make Text Connection Work to create Document Process
        /// <summary>
        /// Saves a new DocumentProcess to the database
        /// </summary>
        /// <param name="model">The Document Process Information.</param>
        /// <returns>The Documment Process ID.</returns>
        public DocumentProcessModel CreateDocumentProcess(DocumentProcessModel model)
        {
            model.ID = 1;
            return model;
        }
    }
}