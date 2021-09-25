using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocioApp
{
    public class Agregar
    {

        //Function to add new cliente
        public void addCustomer(Customer ncliente) {

            //Extrae lo datos de la capa de presentación
            String id = ncliente.customerId;
            String name = ncliente.nameCustomer;
            String direccion = ncliente.addressCustomer;
            String tel = ncliente.telNumCustomer;
            String email = ncliente.emailCustomer;
            //Se insertan lo valores en el metodo  add cliente para comunicarse 
            //Con la capa cliente
            ADCustomer nuevoCliente = new ADCustomer();
            nuevoCliente.addCustomer(id, name, direccion, tel, email);
        
        
        }
        //-------------------------------------------------------------------------------------

        //funtion to Add producto

        public void addProducto (Product nProducto)
        {
            String codeProduct = nProducto.codeProduct;
            string descripProd = nProducto.descriptionProduct;
            Int64 unitaryPrice = nProducto.unitaryPrice;
            int cantidadProducto = nProducto.quantityProduct;

            ADProduct nuevoProducto = new ADProduct();
            nuevoProducto.addProduct(codeProduct,descripProd, unitaryPrice, cantidadProducto);
        }

    }
}
