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
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        
        public static IConfiguration _iconfiguration;
        /// <summary>
        /// The Connectiong String used to Access Integrated Workflow Database
        /// entered in appsettings.json file for IntegratedWorkflowLibrary
        /// </summary>
        public static string CnnString;
        public static void InitializeConnectionString()

        {
            
                var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                _iconfiguration = builder.Build();

            CnnString = _iconfiguration.GetConnectionString("Default");
        }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                SQLConnector sql = new SQLConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

      
    }
}
