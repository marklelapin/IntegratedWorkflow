using IntegratedWorkflowLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.DataAccess
{
    public class TextConnector //TODO add back in : IDataConnection TODO: add back in Interface if using text files in future
    {
        // TODO - Make Text Connection Work to create Document Process 6:50 of https://www.youtube.com/watch?v=wfWxdh-_k_4&t=23644s
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
