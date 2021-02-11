using System;

namespace CourseHunter_37_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(Console.WindowWidth, 150);
            Console.SetWindowSize(Console.WindowHeight, 60);

            int month = int.Parse(Console.ReadLine());
            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Sammer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;

                default:
                    throw new ArgumentException("Unexpected number of month");
                    break;
            }
            Console.WriteLine(season);
            Console.WriteLine(new string('_', 30));

            Console.WriteLine();
            int wedding = int.Parse(Console.ReadLine());
            string name = string.Empty;

            switch (wedding)
            {
                case 5:
                    {
                        name = "Деревянная";
                        break;
                    }
                case 10:
                    name = "Оловянная";
                    break;
                case 15:
                    name = "Хрустальная";
                    break;
                case 20:
                    name = "Фарфоровая";
                    break;
                case 25:
                    name = "Серебряная";
                    break;

                case 30:
                    name = "Жемчужная";
                    break;

                default: //если не в один кейс не зашли процесс идет в default.
                    Console.WriteLine("Не знаем такого.");
                    break;
            }
            Console.WriteLine($"{name} свадьба");
        }
    }
}
