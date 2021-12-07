using IntegratedWorkflowLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.DataAccess
{
    public interface IDataConnection
    {
     DocumentProcessModel  CreateDocumentProcess(DocumentProcessModel model);
    }
}
