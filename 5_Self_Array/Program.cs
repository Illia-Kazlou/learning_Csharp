using System;

namespace _5_Self_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayStart = new int[] { 1, 2, 3, 4, 5 };
            int n = arrayStart.Length;

            int[] arrayFinish = new int[n];

            int summ = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                summ += arrayStart[i];
                arrayFinish[i] = summ;
            }
            Console.WriteLine(string.Join(" ", arrayFinish));  

            Console.ReadLine();
        }
    }   
}
