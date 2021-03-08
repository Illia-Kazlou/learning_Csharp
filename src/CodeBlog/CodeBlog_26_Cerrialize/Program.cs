using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace CodeBlog_26_Serialize
{
    class Program
    {
        static void Main()
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
            // В бинарной сериализации сериализуются и private поля и свойства!!!
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

                //if (deserializeStudents != null)
                //{
                //    foreach (var item in deserializeStudents)
                //    {
                //        Console.WriteLine(item);
                //    }
                //}
            }
            Console.WriteLine(new string('_', 40));


            // SOAP Serialize
            // И здесь сериалзуются private поля и свойства !!!
            SoapFormatter soapFormatter = new SoapFormatter();
            string fullFileNameSoap = ($"{Environment.CurrentDirectory}\\studentSoap.dat");
            using (var fileStream = new FileStream(fullFileNameSoap, FileMode.OpenOrCreate))
            {
                // Сеарилация.
                // Вызываем экземпляр класса и сериализуем его.
                // Первым параметром наш файловый поток.
                soapFormatter.Serialize(fileStream, students);
            }
            using (var fileStream = new FileStream(fullFileNameSoap, FileMode.OpenOrCreate))
            {
                // Десиарилация.
                // Cоздаем объект.
                // Параметром применяется наш файловый поток.
                // И возвращается ОБЪЕКТ!
                var deserializeSoapStudents = soapFormatter.Deserialize(fileStream) as List<Student>; // Приводим к нашему типу.

                //if (deserializeSoapStudents != null)
                //{
                //    foreach (var item in deserializeSoapStudents)
                //    {
                //        Console.WriteLine(item);
                //    }
                //}
            }

            // XML Serializer
            // НЕ! сериалзуются private поля и свойства !!!
            // Этот сеарилизатор должен принимать и иметь в реализации ПУСТОЙ КОНСТРУКТОР!!!
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            string fullFileNameXML = ($"{Environment.CurrentDirectory}\\student.xml");
            using (var fileStreamSerializeXML = new FileStream(fullFileNameXML, FileMode.OpenOrCreate))
            {
                // Сеарилация.
                // Вызываем экземпляр класса и сериализуем его.
                // Первым параметром наш файловый поток.
                xmlSerializer.Serialize(fileStreamSerializeXML, students);
            }
            using (var fileStreamDeserializeXML = new FileStream(fullFileNameXML, FileMode.OpenOrCreate))
            {
                // Десиарилация.
                // Cоздаем объект.
                // Параметром применяется наш файловый поток.
                // И возвращается ОБЪЕКТ!
                var deserializeXMLStudents = xmlSerializer.Deserialize(fileStreamDeserializeXML) as List<Student>; // Приводим к нашему типу.

                //if (deserializeXMLStudents != null)
                //{
                //    foreach (var item in deserializeXMLStudents)
                //    {
                //        Console.WriteLine(item);
                //    }
                //}
                Console.WriteLine("XML end");
            }

            // JSON Serialize!
            // Подключаем Nuget Packet.
            // [DataContract] отмечаем класс дл ясерализации.
            // [DataMember] отмечаем неоходимые поля и свойства.
            // Сериализует и приватные свойсва и поля!

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Student>));
            string fullFileNameJSON = ($"{Environment.CurrentDirectory}\\student.json");

            using (var fileStreamSerializeJSON = new FileStream(fullFileNameJSON, FileMode.OpenOrCreate))
            {
                // Сеарилация.
                // Вызываем экземпляр класса и сериализуем его.
                // Первым параметром наш файловый поток.
                jsonSerializer.WriteObject(fileStreamSerializeJSON, students);
            }
            using (var fileStreamDeserializeJSON = new FileStream(fullFileNameJSON, FileMode.OpenOrCreate))
            {
                // Десиарилация.
                // Cоздаем объект.
                // Параметром применяется наш файловый поток.
                // И возвращается ОБЪЕКТ!
                List<Student> deserializeJSONStudents = jsonSerializer.ReadObject(fileStreamDeserializeJSON) as List<Student>; // Приводим к нашему типу.

                if (deserializeJSONStudents != null)
                {
                    int count = 0;
                    foreach (var item in deserializeJSONStudents)
                    {

                        int count1 = ++count;
                        Console.WriteLine($"{count1} - {item}");
                    }
                }
                Console.WriteLine("End");
            }

            Console.ReadLine();
        }
    }
}
