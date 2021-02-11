using System;

namespace CourseHunter_38_DebagMettigMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's try to calculate the area of a triangle on three sides");

            Console.WriteLine("Enter the length of side AB");
            double sizeSideAB = GetSide();

            Console.WriteLine("Enter the length of side BC");
            double sizeSideBC = GetSide();

            Console.WriteLine("Enter the length of side CA");
            double sizeSideCA = GetSide();

            //Semiperimeter
            double semiperimeter = (sizeSideAB + sizeSideBC + sizeSideCA) / 2;

            //Area formula gerona
            double s = Math.Sqrt(semiperimeter * (semiperimeter - sizeSideAB) * (semiperimeter - sizeSideBC) * (semiperimeter - sizeSideCA));

            Console.WriteLine($"Area a triangle is {s}");

            Console.ReadLine();
        }

        static double GetSide()
        {
            return double.Parse(Console.ReadLine());
        }

    }
}
