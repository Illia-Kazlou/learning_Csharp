using System;
using System.Collections.Generic;
using System.Linq;

namespace AsForMe_DoubleWhereImLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People() { Name = "Nick", Age = 10, Hight = 150 };
            People people2 = new People() { Name = "Mike", Age = 10, Hight = 160 };
            People people3 = new People() { Name = "Nick", Age = 15, Hight = 150 };
            People people4 = new People() { Name = "Nick", Age = 10, Hight = 170 };


            List<People> peoples = new List<People>() { };
            peoples.Add(people);
            peoples.Add(people2);
            peoples.Add(people3);
            peoples.Add(people4);

            var selected = peoples.Where(p => p.Name == "Nick")
                                  .Where(p => p.Age == 10)
                                  //.Where(p => p.Hight > 160)
                                  .ToList();

            foreach (var item in selected)
            {
                Console.WriteLine($"{item.Name} ---- {item.Age} ===== {item.Hight}");
            }



            Console.ReadLine();
        }
    }
}
