using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface new'lenemez. Çünkü interface'lerde yalnızca imza olur. Aşağıdaki interface'imizde görüldüğü gibi yalnızca "void Add();" oluşturduk.
            // İnterface içerisinde herhangi bir işlem olmadığından new'lediğimizde hata alırız.

            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Delete();
            

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.AddCustomer(new InternManager());
        }
        interface IPersonManager
        {
            // unimplemented  operation
            void Add();
            void Update();
        }
        // class'larda -> inherits ---------------- interface'lerde -> implemets
        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                // Müşteri Ekleme Kodları -->
                Console.WriteLine("Müşteri Eklendi!");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri Güncellendi!");
            }
            public void Delete()
            {
                Console.WriteLine("Müşteri Silindi.");
            }
        }
        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                // Personel Ekleme Kodları -->
                Console.WriteLine("Personel Eklendi!");
            }

            public void Update()
            {
                Console.WriteLine("Personel Güncellendi!");
            }
        }
        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer Eklendi!");
            }

            public void Update()
            {
                Console.WriteLine("Stajyer Güncellendi!");
            }
        }
        class ProjectManager 
        {
            public void AddCustomer(IPersonManager personManager)
            {
                personManager.Add();
            }
            
        }
    }
}
