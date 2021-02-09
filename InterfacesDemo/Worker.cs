using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat komutu!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Maaş Komutu!");
        }

        public void Work()
        {
            Console.WriteLine("Worker Çalış Komutu!");
        }
    }
}
