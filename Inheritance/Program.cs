using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance : Kalıtım / Miras Alma demektir.

            // Interface'ler de birer inheritance örneği gib çalışırlar fakat bu inheritance değil implementastondur. Yeni nesil dillerde inharitance gibi de kullanılabilirler.

            // Bir nesne bir kere inheritance alınabilir. Ama birden fazla implementasyon yapılabilir.
            // Yani class değil de interface olsaydı, birden fazla yazılabilirdir. İnheritance her zaman önce yazılır. Interfaceler sonrasından birden fazla yazılabilir.
            // Bir nesnenin tek inheritance'i olabilir.

            Person[] people = new Person[3]
            {
                new Customer{FirstName="Elif" },
                new Student{FirstName="Emre" },
                new Person{FirstName="Ece" }
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
