using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorklowLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }


        public static void InitializeConnections (bool database, bool textFiles)
        {
            if (database)
            {
                // TODO Add int database connection
            }

            if (textFiles)
            {
                // TODO add in textFile connection
            }
        }
    }

}
