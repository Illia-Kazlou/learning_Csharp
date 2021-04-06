using CourseHunter_77_Enumeration;
using System;

namespace CourseHunter_51_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            //c.Hit(120);


            //Console.WriteLine($"Hello World! {c.health}");

            Calculator calc = new Calculator();
            double triangleArea = calc.CalcTriangleArea(2, 5, 6);
            double triangleArea2 = calc.CalcTriangleArea(2, 6);
            double triangleArea3 = calc.CalcTriangleArea(2, 6, 45);

            Console.WriteLine($"Square 1 -> {triangleArea}");
            Console.WriteLine($"Square 2 -> {triangleArea2}");
            Console.WriteLine($"Square 3 -> {triangleArea3}");

            Console.ReadLine();
        }
    }
}
