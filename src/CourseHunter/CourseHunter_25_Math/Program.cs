using System;

namespace CourseHunter_25_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 3)); // число в степень
            Console.WriteLine(Math.Sqrt(8)); // корень числа
            Console.WriteLine(Math.Sqrt(9));

            Console.WriteLine(Math.Round(1.4)); // округление
            Console.WriteLine(Math.Round(1.5));
            Console.WriteLine(Math.Round(1.7));
            Console.WriteLine();

            Console.WriteLine(new string('=', 50));

            Console.WriteLine(Math.Round(1.5, MidpointRounding.AwayFromZero));  //округление
            Console.WriteLine(Math.Round(1.5, MidpointRounding.ToEven));
            Console.WriteLine(Math.Round(1.5, MidpointRounding.ToNegativeInfinity));
            Console.WriteLine(Math.Round(1.5, MidpointRounding.ToPositiveInfinity));

            Console.WriteLine(new string('=', 50));

            //double a = 1.5;

            Console.WriteLine(Math.Ceiling(1.5)); // округление до большего числа всегда если есть цифра после запятой
            Console.WriteLine(Math.Ceiling(1.4));
            Console.WriteLine(Math.Ceiling(1.3));
            Console.WriteLine(Math.Ceiling(1.2));
        }
    }
}
