using System;

namespace CourseHunter_77_Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character(Race.Druid);

            Console.WriteLine(character);

            Console.ReadLine();
        }
    }
}
