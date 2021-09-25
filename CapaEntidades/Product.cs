using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Product
    {
        //Fields Class
        public string codeProduct { get; set; }
        public string descriptionProduct { get; set; }
        public Int64 unitaryPrice { get; set; }
        public int quantityProduct { get; set; }

        //Contructor and Functions class

         public Product (string codeProduct,string descriptionProduct, Int64 unitaryPrice, int quantityProduct)
        {
            this.codeProduct = codeProduct;
            this.descriptionProduct = descriptionProduct;
            this.unitaryPrice = unitaryPrice;
            this.quantityProduct = quantityProduct;
        }







    }
}
