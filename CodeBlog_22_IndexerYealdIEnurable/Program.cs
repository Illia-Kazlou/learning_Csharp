using System;
using System.Collections.Generic;

namespace CodeBlog_22_IndexerYealdIEnurable
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                 new Car ( ) { Name = "Ford", Number = "A001AA"},
                 new Car ( ) { Name = "BMW", Number = "B001BB"}
            };

            Parking parking = new Parking();

            foreach (var car in cars)
            {
                parking.Add(car);
            }

            Console.WriteLine(parking["A001AA"]?.Name);
            Console.WriteLine(parking["A003AA"]?.Name);

            Console.ReadLine();
        }
    }
}
