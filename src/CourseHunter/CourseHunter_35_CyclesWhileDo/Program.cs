using System;

namespace CourseHunter_35_CyclesWhileDo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            //while (age < 18 ) // ЕСЛИ условие выполняется ДЕЛАЕМ
            //{
            //    Console.WriteLine("Haw old are you?");
            //    age = int.Parse(Console.ReadLine());
            //}

            do //Сразу делаем до тех пор пока выполняется УСЛОВИЕ
            {
                Console.WriteLine("Haw old are you?");
                age = int.Parse(Console.ReadLine());
            } while (age < 18);

            Console.WriteLine("Hello!");
            Console.WriteLine(new string('_', 30));



            int[] array = { 5, 7, 8, 9, 10 };
            int i = 0;
            while (i < array.Length) //ИЗДЕВАТЕЛЬСТВО, НО! замена возможная замена цикла foreach
            {
                Console.Write(array[i] + " ");
                i++;
            }

        }
    }
}
