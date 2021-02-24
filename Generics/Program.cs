using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plakalar = new List<int>();
            plakalar.Add(34);
            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka);
            }

            MyList sehirler2 = new MyList();
            sehirler2.Add("İstanbul");
            

            MainList<string> sehirler = new MainList<string>();
            sehirler.Add("Adana");
            
        }
    }
    class MyList
    {
        public void Add(string item)
        {

        }
    }

    class MainList<T> // Generic Class
    {
        public void Add(T item)
        {

        }
    }
}
