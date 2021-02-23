using System;
using System.Collections.Generic;

namespace CourseHunter_66_RefTypesAsArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 15;
            Swap(ref a, ref b); 
            Console.WriteLine($"{a},{b}");


            Console.WriteLine(new string('_', 35));
            List<int> newList = new List<int>();
            AddNumbers(newList);

            foreach (var item in newList)
            {
                Console.Write(item + ";");
            }

            Console.ReadLine();
        }

        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        // Здесь мы будем работать с полноценной копией. И чтобы нам получить данные из метода REF.
        static void Swap (ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp; 
        }
    }
}
