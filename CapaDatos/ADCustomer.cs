using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CapaDatos
{
    public class ADCustomer : DatabaseConnection
    {
        //Add Customer Method 
        public void addCustomer(String customerId, String nameCustomer,String addressCutomer,String telNumberCus, String emailCustomer)
        {

            //Termino esta estructura y voy hacer lo Procesidmientos almecenados en la
            //base datos
            /*
     @customerId	
	@nameCustomer	
	@addressCutomer	
	@telNumberCus	
	@emailCustomer	
             */

            SqlCommand _sqlCommand = new SqlCommand();

            _sqlCommand.Connection = conect();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.CommandText = "SP_ADD_CUSTOMER";
            _sqlCommand.CommandTimeout = 999999999;

            //Se ingresan 5 parametros
            _sqlCommand.Parameters.AddWithValue("customerId",customerId);
            _sqlCommand.Parameters.AddWithValue("nameCustomer", nameCustomer);
            _sqlCommand.Parameters.AddWithValue("addressCutomer",addressCutomer);
            _sqlCommand.Parameters.AddWithValue("telNumberCus",telNumberCus);
            _sqlCommand.Parameters.AddWithValue("emailCustomer",emailCustomer);
            try
            {
                _sqlCommand.Connection.Close();
                _sqlCommand.Connection.Open();
                int estado = _sqlCommand.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                //Probar si se cierra la conexion
                _sqlCommand.Connection.Close();
                throw Ex;
            }
            finally
            {
                _sqlCommand.Connection.Close();
            }



        }

       


    }
}
