using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    class Customer
    {
        //Fields class
        public String customerId { get; set; }
        private String nameCustomer { get; set; }
        private String addressCustomer { get; set; }
        private String telNumCustomer { get; set; }
        private String emailCustomer { get; set; }

        //Constructor
        Customer(String customerId,String nameCustomer, String addressCustomer,String telNumCustomer, String emailCustomer) 
        {
            this.customerId = customerId;
            this.nameCustomer = nameCustomer;
            this.addressCustomer = addressCustomer;
            this.telNumCustomer = telNumCustomer;
            this.emailCustomer = emailCustomer;
        
        }

        //Ingresar cliente metodos-Primer debo conetcar con una clase controladora

        

    }
}
