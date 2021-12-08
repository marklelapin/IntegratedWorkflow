using IntegratedWorkflowLibrary;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentProcessEditor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Finds ConnectionString from applications.json
            IntegratedWorkflowLibrary.GlobalConfig.InitializeConnectionString();
           
           //Initialize Data connection
           IntegratedWorkflowLibrary.GlobalConfig.InitializeConnection(DatabaseTypes.Sql);

            Application.Run(new DocumentProcessEditor());
        }

         

            //TODO work out whats going on with development environment and appsettings
            //.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);
            //.AddEnvironmentVariables#
    }
        
}

