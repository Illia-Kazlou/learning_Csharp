using System;

namespace CourseHunter_36_BreakContinue //в основном для проверки какого-либо условия по циклу
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(Console.WindowWidth, 40);
            Console.SetWindowSize(Console.WindowHeight, 60);

            int[] array = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int atI = array[i];
                    int atJ = array[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3) // это конструкция выводит из цикла 
                    {
                        break;
                    }
                }
                if (counter == 3)  // это конструкция выводит из цикла 
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();

            int[] numbers = { 0, 3, 2, 1, 5, 4, 6, 7, 8, 9 };

            foreach (var item in numbers)
            {
                //Вывод четного числа
                //if (item % 2 == 0)
                //{
                //    Console.WriteLine(item);
                //}

                if (item %2 !=0) // не выкидывает из цикла но переводит поток выполнения вначало цикла!!!
                {
                    continue;
                }
                Console.WriteLine($"Even (четное)  {item}");
            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 30));
            Console.WriteLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Nuber of letters = {numbers[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (numbers[i] == j)
                    {
                        break; //полностью заканчивает выполнение цикла 
                    }
                    Console.Write($"{letters[j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
