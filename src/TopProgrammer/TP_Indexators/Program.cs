using System;

namespace TP_Indexators
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();

            people[0] = new Person { Name = "Nick" };
            people[1] = new Person { Name = "Micke" };
            people[2] = new Person { Name = "Alex" };

            Person newPerson = people[1];

            Console.WriteLine($"{newPerson?.Name}");

            Console.ReadLine();
        }
    }
}
