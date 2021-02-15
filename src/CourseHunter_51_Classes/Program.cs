using System;

namespace CourseHunter_51_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            c.Hit(10);


            Console.WriteLine($"Hello World! {c.Health}");

            Console.ReadLine();
        }
    }
}
