using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CourseHunter_94_Start_LINQ
{
    public static class LinqExtensions 
    { 
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                throw new ArgumentNullException();

            foreach (var item in source)
            {
                action(item);
            }
        }
    }

    class Program
    {
        // LINQ(Language-Integrated Query) представляет простой и удобный язык запросов к источнику данных.
        // В качестве источника данных может выступать объект, реализующий интерфейс IEnumerable
        // (например, стандартные коллекции, массивы), набор данных DataSet, документ XML.
        // Но вне зависимости от типа источника LINQ позволяет применить ко всем один и 
        // тот же подход для выборки данных.
        static void Main(string[] args)
        {
            DisplayLagestFileWithoutLINQ("d:\\");
            Console.WriteLine(new string('-', 35));
            DisplayLagestFileWithLINQ(@"e:\Insatlls\Programs inst\");

            Console.ReadLine();
        }

        private static void DisplayLagestFileWithLINQ(string pathToDir)
        {
            new DirectoryInfo(pathToDir)
                .GetFiles()
                //.OrderBy(KeySelector); // мы должны написать каким образом будет происходить сортировка.
                // вместо верней строчки мы можем использовать лямда выроженияю
                .OrderBy(x => x.Length) // пишем имя аргумента который попадает в метод => тело метода 
                                        // если больше одной строчки открываем { }
                .Take(5)               // дальше продолжаем цепочку и (т.к IEnumerable) 
                                       // дале чтобы воспользоваться foreach надо сделать расширение.
                                       // дальше используем наш созданный метод расширения
                .ForEach(x => Console.WriteLine($"{x.Name} weight = {x.Length / 1000} kB"));

            // Как мы бы делали это если не метод ращирения и делегаты.
            IEnumerable<FileInfo> fileInfos = new DirectoryInfo(pathToDir)
                .GetFiles()
                .OrderBy(x => x.Length)
                .Take(5);

            foreach (var item in fileInfos)
            {
                Console.WriteLine($"{item.Name} weight = {item.Length / 1000} kB");
            }
        }



        static long KeySelector(FileInfo fileInfo)
        {
            return fileInfo.Length;
        }


        private static void DisplayLagestFileWithoutLINQ(string pathToDir)
        {
            var directoryInfo =new DirectoryInfo(pathToDir);
            FileInfo[] files = directoryInfo.GetFiles();

            Array.Sort(files, FileComparison); // дилегат.

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} weight - {file.Length/1000} kB");
            }
        }

        static int FileComparison(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
        } 
    }
}
 