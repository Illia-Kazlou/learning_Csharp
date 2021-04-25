using System;
using System.Collections.Generic;

namespace CourseHunter_27_DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; // свойство показывающее сегоднящнюю дату и время


            Console.WriteLine("Now is {0}", now);
            Console.WriteLine($"Now is {now.Hour}:{now.Minute} time, {now.Day}.{now.Month}.{now.Year}");
            Console.WriteLine(new string('-', 30));

            DateTime dt = new DateTime(2016, 2, 28);
            DateTime newDt = dt.AddYears(4);  // добавление даты 
            Console.WriteLine(newDt);
            Console.WriteLine(new string('-', 30));

            TimeSpan ts = now - dt;
            Console.WriteLine(ts);  // as like ts=now.Subtract(dt)
            Console.WriteLine(new string('-', 30));


            DateTime startDate = DateTime.Now;
            DateTime finishDate = startDate.AddMonths(6);

            Console.WriteLine($"{startDate} + 6 month {finishDate}");
            Console.WriteLine(new string('-', 30));



            static IEnumerable<DateTime> AllDatesBetween(DateTime start, DateTime end)
            {
                for (var day = start.Date; day <= end; day = day.AddDays(1))
                    yield return day;
            }

            int count = 1;

            //Console.WriteLine($"Start date is --- {startDate.AddMonths(-1)}");

            //for (var i = startDate.AddMonths(1).Month; i <= finishDate.Month; i++)
            //{
            //    Console.WriteLine($"{count} month left --- {i}");
            //    count++;
            //}

            for (var i = startDate.AddMonths(1); i <= finishDate; i = i.AddMonths(1))
            {
                Console.WriteLine($"{count} month left --- {i}");
                count++;
            }

            Console.ReadLine();
        }
    }
}
