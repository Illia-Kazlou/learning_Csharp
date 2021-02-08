using System;

namespace CourseHunter_26_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1; //задекларировали переменную
            array1 = new int [10]; //инициализировали массив

            int[] array2 = new int[5];

            int[] array3 = new int[5] { 2, 4, 6, 8, 10 };

            int[] array4 = { 3, -10, 20, 12, 14 };

            Console.WriteLine(array4[1]);

            int number = array4[3];
            Console.WriteLine(number);

            Console.WriteLine(array4.Length); //длинна масива 
            Console.WriteLine(array4[array4.Length-1]); //обращение к крайнему индексу массива

            string str1 = new string("qwerty"); //строку можно представитиь как массив char'ов
            char first = str1[0]; // обращение к первому символу в строке
            char last = str1[str1.Length - 1]; // обращение к последнему символу в строке

            Console.WriteLine($"first element is {first}. The last element id {last}");

            //impossible
            //str1[str1.Length - 1] = 'r';
        }
    }
}
