using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor : Bir sınıfın ilk oluşum anını kontrol etmektir. Bir class'ı new'lediğimiz zaman oluşturduğumuz bloktur.
            // Constructor : Yapıcı blok demektir. 
            // Consturctor oluşturmak için "ctor" yazıp iki kez tab tuşuna basmak yeterlidir.

            Customer customer1 = new Customer {Id=1, FirstName="Elif ", LastName="Pirgaip", City="New York"};

            Customer customer2 = new Customer(2, "Emre", "Pir", "İstanbul");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Erkan";
            customer3.LastName = "Der";
            customer3.City = "London";

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.City);

        }
    }
}
