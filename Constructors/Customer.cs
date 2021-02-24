using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        // default constructor -->
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
