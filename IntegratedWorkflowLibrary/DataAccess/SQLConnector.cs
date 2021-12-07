using IntegratedWorkflowLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace IntegratedWorkflowLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Saves a new DocumentProcess to the database
        /// </summary>
        /// <param name="model">The Document Process Information.</param>
        /// <returns>The Documment Process ID.</returns>
        public DocumentProcessModel CreateDocumentProcess(DocumentProcessModel model)
        {
            var dp = new DynamicParameters();

            using (IDbConnection connection = new SqlConnection(IntegratedWorkflowLibrary.GlobalConfig.CnnString))
            {
                dp.Add("@Title", model.Title);
                dp.Add("IsACtive", model.IsActive);
                dp.Add("@AccessInformation", model.AccessInformation);
                dp.Add("@ObjectInformation", model.ObjectInformation);
                dp.Add("@LaunchPointInformation", model.ObjectInformation);
                dp.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output); //returns the newly created ID from spDocumentProcessCreate

                connection.Execute("dbo.spDocumentProcessCreate", dp, commandType: CommandType.StoredProcedure);

                model.ID = dp.Get<int>("@ID");

                return model;
            }
        }


    }


}

