using System;

namespace CourseHunter_42_Self_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(Console.WindowWidth, 50);
            Console.SetWindowSize(Console.WindowHeight, 60);

            string login = "John";
            string password = "qwetry";

            int countTry = 1;

            while (countTry <= 3)
            {
                Console.WriteLine("Enter login");
                string enterLogin = Console.ReadLine();

                Console.WriteLine("Enter Password");
                string enterPasword = Console.ReadLine();

                if (login == enterLogin && enterPasword == password)
                {
                    Console.WriteLine("Welcom to system");
                    break;
                }
                else
                {
                    countTry++;
                }
            }
            if (countTry == 4)
            {
                Console.WriteLine("Your exceeded the number of tries");
            }
        }
    }
}
