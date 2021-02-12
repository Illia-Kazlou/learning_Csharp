using System;
using System.Collections.Generic;

namespace CourseHunter_45_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

             Dictionary<int, string> intPeople = new Dictionary<int, string>(5); // Правильное написание СЛОВАРЯ. Все очень схоже с массивами и листами. Но у словаря нет индекса КЛЮЧ-ЗНАЧЕНИЕ.

            var people = new Dictionary<int, string>();  // ЗАЧАСТУЮ меняю начальную запись из-зи грамоздкости.
            people.Add(1, "Alexander");                  //Добавление элемента
            people.Add(2, "Sergey");
            people.Add(3, "John");
            people.Add(4, "Vasia");
            Console.WriteLine(people[1]);
            Console.WriteLine("\n");

            intPeople = new Dictionary<int, string>()   //Другой способ добавления элемента.
            {
                {1, "Jo"},
                {2, "Mo"},
                {3, "Yo"}
            };

            foreach (var item in intPeople)
            {
                Console.Write(item + ";");  //output [1, Jo];[2, Mo];[3, Yo]; прогоняет и ключ и значение.
            }
            Console.WriteLine("\n");

            var keys = intPeople.Keys;      //Пробегаем по ключам.
            //ИЛИ
            //Dictionary<int, string>.KeyCollection keys = intPeople.Keys; если развернуть.  KeyCollection - это класс вложенный в Dictionary.
            foreach (var item in keys)
            {
                Console.Write(item + ";"); 
            }
            Console.WriteLine("\n");

            var values = intPeople.Values; //пробегаем по значениям.
            foreach (var item in values)
            {
                Console.Write(item + ";"); 
            }
            Console.WriteLine("\n");

            foreach (var pair in intPeople) // можно воспользоватся pair(ПАРА) выведет без инициализации элементы ключа и значения!!!!!!!!!!!!!!
            {
                Console.Write($"Key is {pair.Key} -- Value is {pair.Value},");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"COUNT {people.Count}"); //свойство счета или калличества элементов.

            bool conteinKey = people.ContainsKey(3); //Метод узнать если у нас такой ключ. Поиск ключа очень быстрый используется метод бинарного поимска!!! Наверное, я так думаю.
            bool conteinValue = people.ContainsValue("John"); // поиск значения big-O(n)

            people.Remove(3); //метод удаления по ключу.

            if (people.TryAdd(3, "Zina"))
            {

            }
            if (people.TryGetValue(2, out string val)) //если по указанному ключу ноходит значение оно заноситься в VAL
            {
                Console.WriteLine(val);
            }



            Console.ReadLine();
        }
    }
}
