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
            IEnumerable<CheesPlayer> list = File.ReadAllLines(path)
                .Skip(1) // пропускаем первую строчку
                .Select(x => CheesPlayer.ParseFideCSV(x)) // Метод расширения (ПРОЕКЦИИ). Берет объект и трансформирует в другой тип.
                                                          //.Select(CheesPlayer.ParseFideCSV) // Синтаксический сахар верхней строки.

                .Where(player => player.Country.Contains("NOR")) // страна
                .OrderBy(player => player.Rank); // сортировка по 
                //.Take(10);  // взять 10 
                            //.ToList(); // метод расширения который IEnumerable превращает в лист.

                int count = 1;
            foreach (var item in list)
            {
                Console.WriteLine($"{count} - {item}");
                count++;
            }
        }

    }
}
