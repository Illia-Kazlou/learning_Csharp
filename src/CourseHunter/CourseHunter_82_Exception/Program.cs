using System;
using System.IO;

namespace CourseHunter_82_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = File.Open("temp.tmp", FileMode.Open);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            finally // Дает большие гарантии, что в результате ошибки заключенный  в него код будет точно ввыполненю
            {
                if (fs != null)
                {
                    fs.Dispose();
                }
            }

            //  Все исключения это инстанции классов
            // Базовый тип не oject а  exception.
            Console.WriteLine("Please input a number");
            string result = Console.ReadLine();

            int number = 0;

            try
            {
                number = int.Parse(result);
            }
            catch (FormatException ex)   // Отлавливаем исключение конкретно свяязанное с FormatException.
            {
                Console.WriteLine("A format exception has occured.");
                Console.WriteLine("Informarion is below:");
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex) // Отлавливаем все исключения так как это базовый тип.
            // Обычно здесь пишут код очистки 
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
