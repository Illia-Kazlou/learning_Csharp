using System;
using System.Collections.Generic;

namespace _12_Self_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //GENERIC
            var product = new Product<int, decimal>("apple", 100, 100);
            var product2 = new Product<decimal, int>("melone", 111.1M, 123);
            var product3 = new Product<double, double>("watermelome", 123.1, 124.3);

            //LIST
            var list = new List<int>();

            //DICTIONARY
            var map = new Dictionary<int, string>();
            map.Add(12, "Pine apple");

            Console.WriteLine("Hello World!");


            Console.ReadLine();
        }
    }
}
