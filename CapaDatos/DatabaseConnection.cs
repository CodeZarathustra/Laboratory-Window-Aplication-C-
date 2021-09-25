using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class DatabaseConnection 
    {
        //This is the intantiation of a SqlConnetion object 
        SqlConnection conection = new SqlConnection();
        //string objCadenaConexion = string.Empty;

        //This is the function to stablish a connetion with database
        public SqlConnection conect()
        {
            try { 
           // objCadenaConexion = ConfigurationManager.ConnectionStrings["ConnSql"].ConnectionString;
               // conection = new SqlConnection(objCadenaConexion);
                conection = new SqlConnection("data Source=DESKTOP-EVOA1H9;initial catalog=NaturVidadb;Integrated Security=True;");
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
