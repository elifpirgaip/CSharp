using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IPerson // Soyut nesne(Tek başına bir şey idafe etmez.)
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
