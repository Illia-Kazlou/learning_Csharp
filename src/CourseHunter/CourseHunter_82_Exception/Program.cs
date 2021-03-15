using System;

namespace CourseHunter_82_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
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
            {
                Console.WriteLine(ex.ToString());
            }


            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
