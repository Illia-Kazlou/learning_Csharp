using System;

namespace CourseHunter_59_NamedArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double triangleArea = calc.CalcTriangleArea(2, 5, 6);
            double triangleArea2 = calc.CalcTriangleArea(2, 6);
            double triangleArea3 = calc.CalcTriangleArea(sizeSideAB: 2, sizeSideBC: 6, alpfa: 45, IsRadians: true);

            Console.WriteLine($"Square 1 -> {triangleArea}");
            Console.WriteLine($"Square 2 -> {triangleArea2}");
            Console.WriteLine($"Square 3 -> {triangleArea3}");

            Console.ReadLine();
        }
    }
}
