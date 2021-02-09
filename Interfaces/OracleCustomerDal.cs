using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added...");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deteled...");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!...");
        }
    }
}
