using System;

namespace CourseHunter_16_BaseAPIstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = new string ("Abracadabra");

            //Метод начинается ли строка с ...
            bool startWhithAbr = name.StartsWith("Abra");
            Console.WriteLine(startWhithAbr);

            //Метод содержится ли в строке другая строка либо символю
            bool containsA = name.Contains("Abr");
            Console.WriteLine(containsA);

            //Метод заканчивается ли строка на ...
            bool endWhithBra = name.EndsWith("bra");
            Console.WriteLine(endWhithBra);

            //Метод находит первое вхождение заданной подстроки или символа в строке. 
            //Если искомый символ или подстрока не обнаружены, то возвращается значение -1(строковым массиве).
            int indexFirstA = name.IndexOf("a", 1);
            Console.WriteLine(indexFirstA);

            //Метод находит крайнее вхождение заданной подстроки или символа в строке.
            int indexLastA = name.LastIndexOf('a');
            Console.WriteLine(indexLastA);

            //Свойство вычисляет количество символов в строкею
            int lengthString = name.Length;
            Console.WriteLine(lengthString);

            //Метод Получение подстроки из строкию
            string substringFrom = name.Substring(5);
            string substringFromTo = name.Substring(2, 6);
            Console.WriteLine(substringFrom);
            Console.WriteLine(substringFromTo);

            string empty = new string ("");
            string whiteSpase = new string (" ");
            string noEmpty = new string (" b");
            string nullString = null;

            Console.WriteLine();
            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            Console.WriteLine();
            Console.WriteLine("WhiteSpase");
            bool whitespase = string.IsNullOrWhiteSpace(whiteSpase);
            Console.WriteLine(whiteSpase);

            Console.WriteLine();
            Console.WriteLine("IsNullOrEmpty");
            bool noempty = string.(empty);
            Console.WriteLine(isNullOrEmpty);
        }
    }
}
