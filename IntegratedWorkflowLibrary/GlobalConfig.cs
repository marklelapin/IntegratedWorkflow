using IntegratedWorkflowLibrary.DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IntegratedWorkflowLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
         public static void InitializeConnection(DatabaseTypes db)
        {
            if (db == DatabaseTypes.Sql)
            {
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }

            else if (db == DatabaseTypes.Text)
            {
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }


        public static IConfiguration _iconfiguration;
        /// <summary>
        /// The Connectiong String used to Access Integrated Workflow Database
        /// entered in appsettings.json file for IntegratedWorkflowLibrary
        /// </summary>
        public static string CnnString;
        public static void InitializeConnectionString()

        {
            //works out the directory of the IntegratedWorkflowLibrary in order to reference its appsettingsfolder       
            string currentDirectory = Directory.GetCurrentDirectory();
            string solutionFolderIdentifier = "IntegratedWorkflow\\"; //TODO - generate this from appsettings of originating Project?
            int solutionDirectoryCutOff = currentDirectory.IndexOf(solutionFolderIdentifier) + solutionFolderIdentifier.Length ;

            string integratedWorkflowLibraryDirectory = currentDirectory.Remove(solutionDirectoryCutOff) + "IntegratedWorkflowLibrary\\";
           

            //Creates configuration from appsettings file in IntegrateWorkflowLibraryDirectory
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(integratedWorkflowLibraryDirectory)
                                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                _iconfiguration = builder.Build();

            CnnString = _iconfiguration.GetConnectionString("Default");
        }

       

      
    }
}
