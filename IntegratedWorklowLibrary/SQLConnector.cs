﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorklowLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Make SQL Connection Work to Create DocumentProcess
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
