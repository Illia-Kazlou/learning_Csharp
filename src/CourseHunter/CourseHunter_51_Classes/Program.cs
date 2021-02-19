using System;

namespace CourseHunter_51_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();
            c.Hit(120);


            Console.WriteLine($"Hello World! {c.health}");

            Calculator calc = new Calculator();
            double triangleArea = calc.CalcTriangleArea(2, 5, 6);
            double triangleArea2 = calc.CalcTriangleArea(2, 6);

            Console.WriteLine($"{triangleArea} 1");
            Console.WriteLine($"{triangleArea2} 2");

            Console.ReadLine();
        }
    }
}
