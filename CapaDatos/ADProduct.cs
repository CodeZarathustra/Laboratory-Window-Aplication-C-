using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CapaDatos
{
    public class ADProduct: DatabaseConnection
    {
        //Function para agregar un nuevo producto* Sería bueno revisar este codigo para optimizar
        //estas dos funciones en 1 sola.

        public void addProduct(string codeProduct, string descriptionProduc, Int64 unitaryPrice, int quantityProduct)
        {
            /*
    @codeProduct	nvarchar(150),
	@descriptionProduc	nvarchar(150),
	@unitaryPrice	bigint,
	@quantityProduct*/


            SqlCommand _sqlCommand = new SqlCommand();

            _sqlCommand.Connection = conect();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.CommandText = "SP_ADD_PRODUCT";
            _sqlCommand.CommandTimeout = 999999999;

            //Se ingresan 5 parametros
            _sqlCommand.Parameters.AddWithValue("codeProduct", codeProduct);
            _sqlCommand.Parameters.AddWithValue("descriptionProduc", descriptionProduc);
            _sqlCommand.Parameters.AddWithValue("unitaryPrice", unitaryPrice);
            _sqlCommand.Parameters.AddWithValue("quantityProduct", quantityProduct);

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
