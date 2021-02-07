using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        // get- set : değeri vermek, değeri okumak.
        // Encapsulation : 
        // property tanımlama : 
        public int ID { get; set; } 
        // single responsibilty'e pek uymaz. -> aşağıdaki kullanım artık pek kullanılmaz.
        string _firstName;
        public string FirstName
        {
            get { return "Sayın " + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
