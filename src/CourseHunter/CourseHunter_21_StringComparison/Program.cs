using System;

namespace CourseHunter_21_StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcde";
            string str2 = "abcde";

            // Простое сравнение строк.
            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal); // Метод сравнения полностью идентичны по своиему смыслу с прошлой записью.
            Console.WriteLine(areEqual);

            string s1 = "Strasse";
            string s2 = "Stra&e";

            // Использовать только при учете специфики определенного алфавита
            areEqual = string.Equals(s1, s2, StringComparison.Ordinal); 
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture); // Метод сравнения если учитывать "культурные" спец. символы 
            Console.WriteLine(areEqual);
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture);
            Console.WriteLine(areEqual);

        }
    }
}
