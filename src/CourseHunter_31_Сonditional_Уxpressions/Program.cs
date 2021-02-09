using System;

namespace CourseHunter_31_Сonditional_Expressions //условные вырожения
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string name = Console.ReadLine();

            Console.WriteLine("Haw old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Haw is you weight in kg?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Haw is you height in meters?");
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / (height * height);
            Console.WriteLine( new string('-', 30));

            Console.WriteLine($"Hi {name}, Your are {age} y.o. Your bodyMassIndex are {bodyMassIndex}");


            bool isToolow = bodyMassIndex <= 18.5;
            bool isNoarmal = 18.5 < bodyMassIndex && bodyMassIndex > 25; //логическое И для ОБЪЕДИНЕНИЯ
            bool isAboveNoarmal = bodyMassIndex >=25 && bodyMassIndex <= 30; //логическое И для ОБЪЕДИНЕНИЯ
            bool isTooFat = bodyMassIndex > 30;

            bool isFat = isTooFat || isAboveNoarmal; //логическое ИЛИ для ОБЪЕДИНЕНИЯ (ХОТЯ БЫ ОДНО)

            if (isFat)
            {
                Console.WriteLine("You'd better to lose same weight");
            }
            else
            {
                if (isToolow)
                {
                    Console.WriteLine("You'd better to append same weight");
                }
                else
                {
                    Console.WriteLine("You weight is OK");
                }
            }

            string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";  //тернарный оператор //ternory operation
        }
    }
}
