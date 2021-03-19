using System;

namespace CourseHunter_87_ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(1, 1);
            Complex complex2 = new Complex(1, 2);

            Complex result = complex.Plus(complex2);

            Console.WriteLine($"{result.Imagenary}?  {result.Real}");

            Console.ReadLine();
        }
    }
}
