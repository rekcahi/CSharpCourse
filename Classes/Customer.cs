using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public string Firstname;//FİELD
        public int Id { get; set; }//PROPERTY
        private string _firstName;
        public string FirstName 
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
