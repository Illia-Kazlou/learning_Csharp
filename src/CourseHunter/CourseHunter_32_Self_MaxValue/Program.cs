using System;

namespace CourseHunter_32_Self_MaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(Console.WindowWidth, 40);
            Console.SetWindowSize(Console.WindowHeight, 30);

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('_', 30));

            int max = a;
            if (b > a)
            {
                max = b;
            }
            Console.WriteLine($"1. Max = {max}");
            Console.WriteLine(new string('_', 30));

            int mAx;
            if (a > b)
            {
                mAx = a;
               
            }
            else
            {
                mAx = b;
                
            }
            Console.WriteLine($"2. Max = {mAx}");
            Console.WriteLine(new string('_', 30));

            int maX = a > b ? a : b;
            Console.WriteLine($"3. Max = {maX}");
        }
    }
}
