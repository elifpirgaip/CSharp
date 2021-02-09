using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat komutu!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Maaş Komutu!");
        }

        public void Work()
        {
            Console.WriteLine("Manager Çalış Komutu!");
        }
    }
}
