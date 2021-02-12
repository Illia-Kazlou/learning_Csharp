using System;

namespace CourseHunter_43_ArraysUnderHhood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7); // используется только для отсартированного поиска.
            Console.WriteLine(index);

            Console.WriteLine(new string('-', 30));
            Console.ForegroundColor = ConsoleColor.Red;

            int[] arrayCopy = new int[10];
            Array.Copy(numbers, arrayCopy, 6); // метод откопировать один массив в другой
            foreach (var item in arrayCopy)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            int[] anotherCopy = new int[10];
            arrayCopy.CopyTo(anotherCopy, 0); //другой метод откопировать один массив в другой
            foreach (var item in anotherCopy)
            {
                Console.Write(item + ";");
            }
            Console.WriteLine("\n");

            Array.Reverse(anotherCopy); //метод переворачивания массива, не создается новый массив а модифицируентся sourece
            foreach (var item in anotherCopy)
            {
                Console.Write(item + ":");
            }
            Console.WriteLine("\n");

            Array.Sort(anotherCopy); //метод сортировки массива, не создается новый массив а модифицируентся sourece
            foreach (var item in anotherCopy)
            {
                Console.Write(item + "*");
            }
            Console.WriteLine("\n");

            Array.Clear(arrayCopy, 0, anotherCopy.Length); //метод очистки массива, не создается новый массив а модифицируентся sourece
            foreach (var item in arrayCopy)
            {
                Console.Write(item + "+");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.ForegroundColor = ConsoleColor.White;

            int[] array1; //задекларировали переменную.
            array1 = new int[10]; //инициализировали массив.

            int[] array2 = new int[5];
            int[] array3 = new int[5] { 2, 4, 6, 8, 10 };
            int[] array4 = { 3, -10, 20, 12, 14 }; // по сути синтаксический сахар.
            Array myArray = new int[5]; //правильная форма написания.

            Array myArray2 = Array.CreateInstance(typeof(int), 5); //создание массива методом!!!!
            myArray2.SetValue(12, 4); //метод установки значения в индекс.
            myArray2.SetValue(13, 0);
            myArray2.SetValue(15, 1);

            Console.WriteLine(myArray2.GetValue(1));

            Console.ReadLine();
        }
    }
}
