using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
