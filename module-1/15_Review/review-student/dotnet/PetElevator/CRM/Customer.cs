using System;
using System.Collections.Generic;
using System.Text;
using PetElevator.Shared;


namespace PetElevator.CRM
{
    class Customer : Person
    {
        public string PhoneNumber { get; set; }
        public List<string> Pets { get; set; } = new List<string>();



        public Customer(string firstName, string lastName, string phoneNumber) : base(firstName, lastName)
        {
            this.PhoneNumber = phoneNumber;
            
        }

        public Customer(string firstName, string lastName) : this(firstName, lastName, "")
        {
            
        }
            public string phoneNumber   //derived property
            {
            get
                {
                return " ";
                }
            }


    

    }
}

