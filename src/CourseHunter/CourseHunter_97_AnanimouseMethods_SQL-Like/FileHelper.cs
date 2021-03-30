using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseHunter_97_AnanimouseMethods_SQL_Like
{
    public class FileHelper
    {
        public static void MinMaxSummAverage(string path)
        {
            var lines = File.ReadAllLines(path);
            IEnumerable<CheesPlayer> list = lines
                .Skip(1) // пропускаем первую строчку
                .Select(x => CheesPlayer.ParseFideCSV(x))

                //.Where(player => player.Birthday > 1989) // год рождения
                // Ниже старый синтаксис верхней записи.
                .Where(delegate(CheesPlayer cheesPlayer) { return cheesPlayer.Birthday > 1989; }) // Полный эквивалент верхней записи.
                // это и есть аноанимный метод.

                .OrderBy(player => player.Rank) // сортировка по
                .ThenBy(player => player.Country) // вторая сортировка по стране
                .Take(10)  // взять 10 
                .ToList(); // метод расширения который IEnumerable превращает в лист.

            // Еще один вариант синтаксиса не смльно используемый.
            // SQL-like sintaxis.
            IEnumerable<CheesPlayer> list2 = lines
                .Skip(1) // пропускаем первую строчку
                .Select(x => CheesPlayer.ParseFideCSV(x));

            var filterd = from player in list2
                          where player.Birthday > 1989
                          orderby player.Rating descending
                          select player;
        }

    }
}
