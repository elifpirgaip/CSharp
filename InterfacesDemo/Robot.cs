using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalış Komutu!");
        }
    }
}
