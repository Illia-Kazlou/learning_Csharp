using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CourseHunter_95_LINQ_ParsingCSV
{
    public class FileHelper
    {
        public static void MinMaxSummAverage(string path)
        {
            var lines = File.ReadAllLines(path);
            IEnumerable<CheesPlayer> list = lines
                .Skip(1) // пропускаем первую строчку
                .Select(x => CheesPlayer.ParseFideCSV(x)) // Метод расширения (ПРОЕКЦИИ). Берет объект и трансформирует в другой тип.
                                                          //.Select(CheesPlayer.ParseFideCSV) // Синтаксический сахар верхней строки.

                .Where(player => player.Birthday > 1989) // год рождения
                .OrderBy(player => player.Rank) // сортировка по
                .ThenBy(player => player.Country); // вторая сортировка по стране
                                                   //.Take(10);  // взять 10 
                                                   //.ToList(); // метод расширения который IEnumerable превращает в лист.

            //    int count = 1;
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{count} - {item}");
            //    count++;
            //}

            // ИЗ УЖЕ ВЫБРАННЫХ!!!!!!!

            Console.WriteLine($"The lowest rating in TOP: {list.Min(x => x.Rating)} ");
            Console.WriteLine($"The highest rating in TOP: {list.Max(x => x.Rating)}");
            Console.WriteLine($"The average rating in TOP: {list.Average(x => x.Rating)}");

            Console.WriteLine(new string ('-', 35));

            Console.WriteLine(list.First()); //если последовательность пустая будет выбрашено исключение. А нет - первый элемент.
            Console.WriteLine(list.Last());

            Console.WriteLine(new string('-', 35));

            // эти расширения имеют свои делегаты, поэтому мы их можем использовать для других операций.
            Console.WriteLine(list.First(player => player.Country == "USA"));

            // если не нужна ошибка используй брата окрабата.
            Console.WriteLine(list.LastOrDefault(player => player.Country == "USA"));

            Console.WriteLine(new string('-', 35));

            Console.WriteLine(list.First(player => player.Country == "FRA"));
            Console.WriteLine(list.Single(player => player.Country == "FRA"));
            Console.WriteLine(list.SingleOrDefault(player => player.Country == "BRA"));
        }

    }
}
