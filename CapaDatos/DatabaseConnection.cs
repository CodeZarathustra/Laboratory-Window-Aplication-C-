using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    class DatabaseConnection 
    {
        //This is the intantiation of a SqlConnetion object 
        SqlConnection conection = new SqlConnection();
        string objCadenaConexion = string.Empty;

        //This is the function to stablish a connetion with database
        public SqlConnection conect()
        {
            try
            {
                objCadenaConexion = ConfigurationManager.ConnectionStrings["ConectionSQlServer"].ConnectionString;
                conection = new SqlConnection(objCadenaConexion);
                conection.Open();

                return conection;

            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);

            }


        }

    }
}
