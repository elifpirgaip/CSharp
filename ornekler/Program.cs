using System;

namespace ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add(20,30);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Add(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}
