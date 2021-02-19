using System;

namespace CourseHunter_47_MultidimensionalANDjaggetArrays //многомерный массив и зубчатый
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            // 1;2;3
            // 4;5;6
            // 7;8;9

            int[,] multidimensionalArrays = new int[2, 3];
            int[,] multidimensionalArrays2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] multidimensionalArrays3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < multidimensionalArrays3.GetLength(0); i++)
            {
                for (int j = 0; j < multidimensionalArrays3.GetLength(1); j++)
                {
                    Console.Write($"{multidimensionalArrays3[i, j]} ");
                }
                Console.WriteLine();
            }

            int[][] jaggetArrays = new int[4][];
            jaggetArrays[0] = new int[1];
            jaggetArrays[1] = new int[3];
            jaggetArrays[2] = new int[2];
            jaggetArrays[3] = new int[4];

            Console.WriteLine("Enter the numbers for a jagget array");

            for (int i = 0; i < jaggetArrays.Length; i++)
            {
                for (int j = 0; j < jaggetArrays[i].Length; j++)
                {
                    string str = Console.ReadLine();
                    jaggetArrays[i][j] = int.Parse(str);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Print elements");

            for (int i = 0; i < jaggetArrays.Length; i++)
            {
                for (int j = 0; j < jaggetArrays[i].Length; j++)
                {
                    Console.Write(jaggetArrays[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
