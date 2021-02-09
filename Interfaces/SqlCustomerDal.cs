using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!...");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deteled...");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!...");
        }
    }
}
