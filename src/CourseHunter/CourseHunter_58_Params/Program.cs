using System;

namespace CourseHunter_58_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();


            //для вызова простого метода из другого класса.
            double avr = calc.Average(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //для упращения вышеуказанной строки. Здесь массив создается ИМПЛИЦИДНО, т.е не явно)
            double avr2 = calc.Average2( 1, 2, 3, 4, 5, 6, 7, 8, 9 );

            Console.WriteLine(new string('_',35));

            Console.WriteLine($"Average {avr}");
            Console.WriteLine($"Average2 {avr2}");

            Console.ReadLine();
        }
    }
}
