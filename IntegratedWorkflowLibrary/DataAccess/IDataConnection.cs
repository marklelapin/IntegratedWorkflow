using IntegratedWorkflowLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// Create a new DocumentProcess in database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        DocumentProcessModel  CreateDocumentProcess(DocumentProcessModel model);

        /// <summary>
        /// Updates existing DocumentProcess in database.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        DocumentProcessModel UpdateDocumentProcess(DocumentProcessModel model);

        LaunchPointModel CreateLaunchPoint(LaunchPointModel model);

        /// <summary>
        /// Retrieves list of all Launch Points from database.
        /// </summary>
        /// <returns></returns>
        List<LaunchPointModel> GetLaunchPoints();

        /// <summary>
        /// Retrieves list of all Launch Points associated with DocumentProcessID
        /// </summary>
        /// <param name="documentProcessID"></param>
        /// <returns></returns>
        List<LaunchPointModel> GetDocumentProcessLaunchPoints(int documentProcessID);

        /// <summary>
        /// Retrieves list of all DocumentProcessObjects associated with DocumentProcessID
        /// </summary>
        /// <param name="documentProcessID"></param>
        /// <returns></returns>
        List<DocumentProcessObjectModel> GetDocumentProcessObjects(int documentProcessID);

        /// <summary>
        /// Retrieves list of all AccessRules associated with DocumentProcessID
        /// </summary>
        /// <param name="documentProcessID"></param>
        /// <returns></returns>
        List<AccessRuleModel> GetDocumentProcessAccessRules(int documentProcessID);

        /// <summary>
        /// Retrieves list of all DocumentProcesses.
        /// </summary>
        /// <param name="searchText">
        /// Containing searchText.
        /// </param>
        /// <param name="activeOnly">
        /// Only active ones returned if true. Otherwise active and inactive.
        /// </param>
        /// <returns></returns>
        List<DocumentProcessModel> SearchDocumentProcesses(string searchText, bool activeOnly);

        /// <summary>
        /// Retrieves all of the available AccessTypes from database.
        /// </summary>
        /// <returns></returns>
        List<AccessTypeModel> GetAccessTypes();

        /// <summary>
        /// Retreives all of the available AccessEntityTypes from database.
        /// </summary>
        /// <returns></returns>
        List<AccessEntityTypeModel> GetAccessEntityTypes();

        /// <summary>
        /// List all of the AccessEntities from database for the specific AccessEntityType
        /// </summary>
        /// <param name="accessEntityTypeID"></param>
        /// <returns></returns>
        List<AccessEntityModel> GetAccessEntities(int accessEntityTypeID);

        /// <summary>
        /// Retrieves all of the available Object Types to associated with Document Process from database
        /// </summary>
        /// <returns></returns>
        List<ObjectTypeModel> GetObjectTypes();

    }
}
