using System;

namespace _12_5_Self_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }

            Console.Read();
        }
    }
}
