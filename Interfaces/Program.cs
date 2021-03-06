﻿using System;

namespace Interfaces
{
    class Program
    {
        private static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
            //customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.WriteLine(" ");

            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Elif", LastName = "Pirgaip", Address = "London" });

            Console.WriteLine(" ");

            Student student = new Student
            {
                Id = 2,
                FirstName = "Emre",
                LastName = "Pirgaip",
                Departmant = "Architecture"
            };
            manager.Add(student);


            Console.ReadLine();
        }
    }
    // isimlendirme standardı : "I" ile başlar.
    // en büyük kullanım amacı : temel nesne oluşturup, bütün nesneleri ondan implemente etmektir.

    // Polymorphism : çok biçimlilik anlamına gelir. Bir nesneyi farklı amaçlarla implamente edip,
    // bunların belli bir kısmına ya da tamamına ulaşabilmektir.

}
