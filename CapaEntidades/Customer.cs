using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class Customer
    {
        //Fields class
        public String customerId { get; set; }
        public String nameCustomer { get; set; }
        public String addressCustomer { get; set; }
        public String telNumCustomer { get; set; }
        public String emailCustomer { get; set; }

        //Constructor
        public Customer(String customerId,String nameCustomer, String addressCustomer,String telNumCustomer, String emailCustomer) 
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
