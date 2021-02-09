using System;

namespace CourseHunter_29_Self_Euclid_sAlgorithm
{
    class Program
    {
        /// <summary>
        /// Algoritm help to find the max common divider (делитель).
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            //while ((firstNumber != 0) && (secondNumber != 0))
            //{
            //    if (firstNumber > secondNumber)
            //    {
            //        firstNumber %= secondNumber;
            //    }
            //    else
            //    {
            //        secondNumber %= firstNumber;
            //    }
            //}

            Console.WriteLine("NOD is {0}", GetNODRecurs(secondNumber, firstNumber % secondNumber));

            static int GetNODRecurs(int firstNumber, int secondNumber)
            {
                if (secondNumber == 0)
                {
                    return firstNumber;
                }
                else
                {
                    return GetNODRecurs(secondNumber, firstNumber % secondNumber);
                }
            }

            

            //if (firstNumber == 0)
            //{
            //    Console.WriteLine("NOD is {0}", GetNODRecurs(secondNumber));
            //}
            //if (secondNumber == 0)
            //{
            //    Console.WriteLine($"NOD is {firstNumber}");
            //}
        }
    }
}
