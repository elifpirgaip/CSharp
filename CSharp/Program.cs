using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class'lar basit olarak : 1- Yapmak istediğimiz işlemleri gruplara ayırmak,
            //            2- Grup üzerinden işlemleri yapmak,
            //            3- Rahatlıkla gruplara ulaşmak için kullanılır. 

            CustomerManager customerManager = new CustomerManager(); // Class'ımızı oluşturduktan sonra, burada çağırıyoruz.
            customerManager.Add(); // Buralarda da kullanılıyoruz.
            customerManager.Update();

            Console.WriteLine(" ");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
            productManager.Delete();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.FirstName = "Elif";
            customer.LastName = "Pirgaip";
            customer.City = "İstanbul";

            // yukarıdaki kullanım aşağıdaki şekilde de yapılabilir.
            // süslü parantezleri açtıktan sonra "{}" crtl + space tuşlarına bastığımızda parametrelerimiz gelir, kolaylıkla ekleriz.

            Customer customer2 = new Customer
            {
                ID = 2,
                FirstName = "Emre",
                LastName = "Pirgaip",
                City = "Ankara"
            };


            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }

}

