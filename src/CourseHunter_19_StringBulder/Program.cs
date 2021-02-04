using System;
using System.Text;

namespace CourseHunter_19_StringBulder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            
            //метод дабавления в стинг билдер новой строки.
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John ");
            //Метод добавление с новой строчки
            sb.AppendLine("!");

            Console.WriteLine(sb);

            //Метод загона все в строкую 
            string str = sb.ToString();
            Console.WriteLine(str);
        }
    }
}
