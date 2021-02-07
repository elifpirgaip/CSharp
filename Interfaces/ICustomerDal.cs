using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    // Dal : Data Access Layer'dan geliyor.
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

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

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
