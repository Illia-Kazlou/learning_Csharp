using System;

namespace _11R_Self_Operators_overload
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MathAction calc = new MathAction();

            calc.Add(1, 3);
            calc.Add(1, 2, 4);
            calc.Add(1, 2, 3, 4);
            calc.Add(1.3, 1.8);

            Console.ReadLine();
        }


    }
}
