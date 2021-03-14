using System;

namespace CourseHunter_81_LazyEvaluationYield
{
    class Program
    {
        static void Main(string[] args)
        {
            StackBaseOnObect<int> stackBaseOnObect = new StackBaseOnObect<int>();
            stackBaseOnObect.Push(1);
            stackBaseOnObect.Push(3);
            stackBaseOnObect.Push(2);

            foreach (var item in stackBaseOnObect)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
