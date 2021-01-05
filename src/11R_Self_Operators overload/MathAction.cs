using System;

namespace _11R_Self_Operators_overload
{
    public class MathAction
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"The ressult is {result}");
        }

        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"The ressult is {result}");
        }

        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"The ressult is {result}");
        }

        public int Add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            Console.WriteLine($"The ressult is {result}");
            return result;
        }
    }
}
