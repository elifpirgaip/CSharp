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
}
