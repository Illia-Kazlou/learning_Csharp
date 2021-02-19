using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseHunter_44_CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(new string('-', 30));
          
            var initList = new List<int>();                     //простое объявление массива
            var initList2 = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };

            initList2.Add(11);              //метод добавления в список указанного значения.
            foreach (var item in initList2)
            {
                Console.Write(item + ";");
            }
            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 30));

            Console.ForegroundColor = ConsoleColor.Red;
            int[] intArray = new int[] { 2, 3, 4, 5, 6, 7, 8, };
            initList2.AddRange(intArray);                   //метод добавления массива в список
            foreach (var item in initList2)
            {
                Console.Write(item + ";");
            }
            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 30));

            Console.ForegroundColor = ConsoleColor.White;
            if (initList2.Remove(3))                    // метод удаления который возвращает BOOL значение, и УДАЛЯЕТ ТОЛЬКО ПЕРВОЕ ПОПАДАНИЕ.
            {
                foreach (var item in initList2)
                {
                    Console.Write(item + ";");
                }
            }
            Console.WriteLine("Удаление по индексу");
            initList2.RemoveAt(0);                      // метод удаления по индексу
            foreach (var item in initList2)
                {
                    Console.Write(item + ";");
                }

            initList2.Reverse();                    //метод переворачивания 
            bool contains = initList2.Contains(8);                  //метод содержится элемент или нет

            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 30));
            int min = initList2.Min();                  //метод нахождения минимального значения пространсто имен LINQ -> интегрированный язык запросов
            int max = initList2.Max();                  //метод нахождения максимального значения пространсто имен LINQ
            Console.WriteLine(min);
            Console.WriteLine(max);
            foreach (var item in initList2)
            {
                Console.Write(item + ";");
            }
            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 30));

            int indexOf = initList2.IndexOf(4);                     // метод нахождения первого индекса значения
            int lastIndexOf = initList2.LastIndexOf(8);                     // метод нахождения последнего индекса значения
            initList2.Reverse();

            for (int i = 0; i < initList2.Count; i++)
            {
                Console.Write(initList2[i] + "+") ;
            }
            Console.WriteLine("\n");
            Console.WriteLine(new string('-', 30));

            Console.ReadLine();
        }
    }
}
