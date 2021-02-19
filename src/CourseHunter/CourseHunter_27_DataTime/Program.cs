using System;

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

        }
    }
}
