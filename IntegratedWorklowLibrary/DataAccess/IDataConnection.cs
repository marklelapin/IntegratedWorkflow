using IntegratedWorklowLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorklowLibrary.DataAccess
{
    public interface IDataConnection
    {
        DocumentProcessModel CreateDocumentProcess(DocumentProcessModel model);
    }
}
