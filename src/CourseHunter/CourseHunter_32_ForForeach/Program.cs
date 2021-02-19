using System;

namespace CourseHunter_33_ForForeach_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 13,24,36,47,58,69,70 };

            for (int i = 0; i <= array.Length; i++)
            {
                Console.Write(i + ",");

            }
            Console.WriteLine();
            Console.WriteLine( new string('_', 30));

            int[] mass = { 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass.GetValue(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30));

            int[] array3 = { 13, 24, 36, 47, 58, 69, 70 };
            for (int i = array3.Length-1 ; i >= 0; i--)
            {
                Console.Write(array3.GetValue(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30));

            int[] array4 = { 13, 24, 36, 47, 58, 69, 70 };
            for (int j = array3.Length - 1; j >= 0; j--)
            {
                if (array4[j] % 2 == 0)
                {
                    Console.Write(array4[j] + " ");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30));

            foreach (var item in array4) //нет итератора и поэтому значения выдаются только от начала и до конца
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30));
        }
    }
}
