using System;

namespace CourseHunter_29_Self_FormulaHerona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's try to calculate the area of a triangle on three sides");

            Console.WriteLine("Enter the length of side AB");
            double sizeSideAB = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side BC");
            double sizeSideBC = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side CA");
            double sizeSideCA = double.Parse(Console.ReadLine());

            //Semiperimeter
            double semiperimeter = (sizeSideAB + sizeSideBC + sizeSideCA) / 2;

            //Area formula gerona
            double s = Math.Sqrt(semiperimeter * (semiperimeter - sizeSideAB) * (semiperimeter - sizeSideBC) * (semiperimeter - sizeSideCA));

            Console.WriteLine($"Area a triangle is {s}");
        }
    }
}
