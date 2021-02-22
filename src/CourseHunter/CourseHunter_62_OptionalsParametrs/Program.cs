using System;

namespace CourseHunter_62_OptionalsParametrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.CalcTriangleArea(10, 20, 30, true);


            Console.ReadLine();
        }
    }
}
