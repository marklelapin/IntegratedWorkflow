﻿using IntegratedWorkflowLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;
using System.Linq;

namespace IntegratedWorkflowLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private static string CnnString = IntegratedWorkflowLibrary.GlobalConfig.CnnString;

        /// <summary>
        /// Saves a new DocumentProcess to the database
        /// </summary>
        /// <param name="model">The Document Process Information.</param>
        /// <returns>The Documment Process ID.</returns>
        public DocumentProcessModel CreateDocumentProcess(DocumentProcessModel model)
        {
            var dp = new DynamicParameters();

            using (IDbConnection connection = new SqlConnection(CnnString))
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

        public LaunchPointModel CreateLaunchPoint(LaunchPointModel model)
        {
            var dp = new DynamicParameters();

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                dp.Add("@Title", model.Title);
                dp.Add("@IsActive", model.IsActive);
                dp.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output); //returns newly created ID

                connection.Execute("dbo.spLaunchPointCreate", dp, commandType: CommandType.StoredProcedure);

                model.ID = dp.Get<int>("@ID");

                return model;
            }
        }

        public List<AccessEntityTypeModel> GetAccessEntityTypes()
        {
            List<AccessEntityTypeModel> output;

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                output = connection.Query<AccessEntityTypeModel>("Select ID,Title FROM dbo.AccessEntityTypes").ToList();
            }
            return output;
        }


        public List<AccessTypeModel> GetAccessTypes()
        {
            List<AccessTypeModel> output;

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                output = connection.Query<AccessTypeModel>("SELECT ID,Title,AllowView,AllowEdit,AllowDownwards,AllowMatch FROM dbo.AccessTypes").ToList();
            }

            return output;
        }

        public List<AccessEntityModel> GetDocumentProcessAccessEntities(int documentProcessID)
        {
            List<AccessEntityModel> output;
            var dp = new DynamicParameters();

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                dp.Add("@DocumentProcessID", documentProcessID);
                output = connection.Query<AccessEntityModel>("dbo.spDocumentProcessAccessEntityGet", dp,commandType:CommandType.StoredProcedure).ToList();
            }

            return output;
        
         }

        public List<LaunchPointModel> GetDocumentProcessLaunchPoints(int documentProcessID)
        {
            List<LaunchPointModel> output;
            var dp = new DynamicParameters();

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                dp.Add("@DocumentProcessID", documentProcessID);
                output = connection.Query<LaunchPointModel>("dbo.spDocumentProcessLaunchPointGet", dp,commandType:CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<DocumentProcessObjectModel> GetDocumentProcessObjects(int documentProcessID)
        {
            List<DocumentProcessObjectModel> output;
            var dp = new DynamicParameters();

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                dp.Add("@DocumentProcessID", documentProcessID);
                output = connection.Query<DocumentProcessObjectModel>("dbo.spDocumentProcessObjectGet", dp, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<LaunchPointModel> GetLaunchPoints()
        {
            List<LaunchPointModel> output;

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                output = connection.Query<LaunchPointModel>("dbo.spLaunchPointGetActive").ToList();
            }

            return output;
        }

        public List<DocumentProcessModel> SearchDocumentProcesses(string searchText, bool activeOnly)
        {
            List<DocumentProcessModel> output;
            var dp = new DynamicParameters();

            using (IDbConnection connection = new SqlConnection(CnnString))
            {
                dp.Add("@SearchText", searchText);
                dp.Add("ActiveOnly", activeOnly);
                output = connection.Query<DocumentProcessModel>("dbo.spDocumentProcessSearch", dp, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }
    }
}