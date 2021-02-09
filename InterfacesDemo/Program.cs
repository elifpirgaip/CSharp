using System;

namespace InterfacesDemo
{
    // SOLID'in 4. prensibi --> (Interface Segregation)
    // Interface'lerin doğru planlanması örneği --> 
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work(); // Tüm personle "work" emri verilmiş oluyor.
            }

            Console.WriteLine(" ");

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.WriteLine(" ");

            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }
}
