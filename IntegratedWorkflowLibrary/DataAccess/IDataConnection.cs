using IntegratedWorkflowLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.DataAccess
{
    public interface IDataConnection
    {
     DocumentProcessModel  CreateDocumentProcess(DocumentProcessModel model);

        LaunchPointModel CreateLaunchPoint(LaunchPointModel model);

        List<LaunchPointModel> GetLaunchPoints();

        List<LaunchPointModel> GetDocumentProcessLaunchPoints(int documentProcessID);

        List<DocumentProcessObjectModel> GetDocumentProcessObjects(int documentProcessID);

        List<AccessEntityModel> GetDocumentProcessAccessEntities(int documentProcessID);

        List<DocumentProcessModel> SearchDocumentProcesses(string searchText, bool activeOnly);

        List<AccessTypeModel> GetAccessTypes();

        List<AccessEntityTypeModel> GetAccessEntityTypes();

    }
}
