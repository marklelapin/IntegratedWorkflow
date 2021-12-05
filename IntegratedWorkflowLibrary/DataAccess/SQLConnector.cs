using IntegratedWorkflowLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegratedWorkflowLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Make SQL Connection Work to Create DocumentProcess
        /// <summary>
        /// Saves a new DocumentProcess to the database
        /// </summary>
        /// <param name="model">The Document Process Information.</param>
        /// <returns>The Documment Process ID.</returns>
        public DocumentProcessModel CreateDocumentProcess(DocumentProcessModel model)
        {
            using (SqlConnection con = new SqlConnection("IntegratedWorkflow"))
            {
                SqlCommand cmd = new SqlCommand("SP_COUNTRY_GET_LIST", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listCountryModel.Add(new CountryModel
                    {
                        Id = Convert.ToInt32(rdr[0]),
                        Country = rdr[1].ToString(),
                        Active = Convert.ToBoolean(rdr[2])
                    });
                }
            }
        }

    }


}
}
