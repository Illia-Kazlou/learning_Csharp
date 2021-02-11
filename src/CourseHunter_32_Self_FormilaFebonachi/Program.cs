using System;

namespace CourseHunter_39_Self_FormilaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(Console.WindowWidth, 40);
            Console.SetWindowSize(Console.WindowHeight, 30);

            Console.WriteLine("Enter the nuber of Fibonacci numbers, what you want  to generate");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacci = new int [n];

            int value0 = 0;
            int value1 = 1;

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                int valueNext = value0 + value1;
                fibonacci[i] = valueNext;

                value0 = value1;
                value1 = valueNext;
            }
            foreach (var item in fibonacci)
            {
                Console.WriteLine(item);
            }
        }
    }
}
