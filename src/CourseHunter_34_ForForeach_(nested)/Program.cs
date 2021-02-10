using System;

namespace CourseHunter_34_ForForeach_Nested //вложеные 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int atI = array[i];
                    int atJ = array[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        int atI = array[i];
                        int atJ = array[j];
                        int atK = array[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Tripets ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }

                }
            }
        }
    }
}
