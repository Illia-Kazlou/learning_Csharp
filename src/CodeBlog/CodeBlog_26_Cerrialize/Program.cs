using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeBlog_26_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            for (int i = 1; i < 10; i++)
            {
                groups.Add(new Group(i, "Group " + i));
            }

            var students = new List<Student>();
            for (int i = 0; i < 300; i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i % 9]
                };

                students.Add(student);
            }

            // Создаем класс бинарного форматера.
            BinaryFormatter binaryFormater = new BinaryFormatter();

            string fullFileName = ($"{Environment.CurrentDirectory}\\student.dat");

            // Создает файловый поток
            // Первым параметром принимет конечный путь к файлу, фторой - файловая опция.
            using (var fileStream = new FileStream(fullFileName, FileMode.OpenOrCreate))
            {
                // Сеарилация.
                // Вызываем экземпляр класса и сериализуем его.
                // Первым параметром наш файловый поток.
                binaryFormater.Serialize(fileStream, students);
            }

            using (var fileStream = new FileStream(fullFileName, FileMode.OpenOrCreate))
            {
                // Десиарилация.
                // Cоздаем объект.
                // Параметром применяется наш файловый поток.
                // И возвращается ОБЪЕКТ!

                var deserializeStudents = binaryFormater.Deserialize(fileStream) as List<Student>; // Приводим к нашему типу.

                if (deserializeStudents != null)
                {
                    foreach (var item in deserializeStudents)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
