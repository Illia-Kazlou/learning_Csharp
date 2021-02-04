using System;
using System.Text;
using System.Threading;

namespace CourseHunter_20_StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = new string("John");
            int age = (10);
            string str1 = string.Format("My name is {0}. I am a {1} y.o.", name, age); // {} - называется плейсхолдер.
            string str2 = $"My name is {name}. I am a {age} y.o."; // - интерполирование строк.
            /*
            Тоже самое что и ..
            string str2 = "My name is " + name + "I am a " + age + " y.o.*/

            Console.WriteLine(str2);

            string str3 = "My name is \nJohn"; // - с новой строки.
            string str35 = $"My name is {Environment.NewLine}John"; // - тоже самое что и выше, только смысл в кросплатформенности.

            string str4 = "I am \t30"; // - табуляция.

            string str5 = " I am John and I o \"good\" programmer."; // -дял того чтобы использовать ковычки.

            string str6 = "C:\\temp\\test.txt"; // - для того чтобы не воспринимать слеш, закрываем его вторым.
            string str65 = @"C:\temp\test.txt"; // - verbatim strings или дословные строки.
            Console.WriteLine(str35);

            string str10 = string.Format("My name is {0}. I am a {1} y.o.", name, age); // {} - называется плейсхолдер.

            int answer = 42;
            string str11 = string.Format("{0:d}", answer); // - для вывода целочисленных.
            string str12 = string.Format("{0:d7}", answer); // -  выводит то количество символов которое указано после d. PS добавляет 0000.

            string str13 = string.Format("{0:f}", answer); // - через запятую выводит 2 нуля справа.
            string str14 = string.Format("{0:f6}", answer); // - через запятую выводит указанное количество нулей справа. Работает как оругление

            Console.OutputEncoding = Encoding.UTF8;
            double money = 12.8;
            string str15 = string.Format("{0:C}", money);
            string str16 = $"{money:C2}";

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU"); // - Локализация.
            string str17 = $"{money:C2}";

            Console.WriteLine(str17);
            Console.WriteLine(str16);
        }
    }
}
