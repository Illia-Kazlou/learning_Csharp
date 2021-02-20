using System;

namespace CourseHunter_60_Output_outParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            string enterValue = Console.ReadLine();

            //int number; // так надо было писать раньше теперь это не надо.

            bool isParsed = int.TryParse(enterValue, out int number); // просто в out  указываешь тип переменной.

            if (isParsed)
            {
            Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Try again");
            }

            Console.WriteLine(new string('_', 35));

            Calculator calc = new Calculator();

            //помимо того что данный метод ВОЗВРАЩАЕТ bool, он также показывает нам результат выполнения.
            if (calc.TryDivide(9,2, out double result))
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
