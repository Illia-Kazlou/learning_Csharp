using System;

namespace CourseHunter_78_Self_StackOnObject
{
    class Program
    {
        static void Main(string[] args)
        {
            StackBaseOnObect stackBaseOnObect = new StackBaseOnObect();
            stackBaseOnObect.Push("1 - ASD,J.LKJNKJSA");
            stackBaseOnObect.Push("2 - ASD,J.LKJNKJSA");
            stackBaseOnObect.Push("3 - ASD,J.LKJNKJSA");
            stackBaseOnObect.Push(2);
            stackBaseOnObect.Push(0.2);
            stackBaseOnObect.Push('r');

            // Invalid cast exeption
            while (stackBaseOnObect.Count != 0)
            {
                Console.WriteLine((int)stackBaseOnObect.Peek());
                stackBaseOnObect.Pop();
            }


            Console.WriteLine(stackBaseOnObect.Peek());

            stackBaseOnObect.Pop();

            Console.WriteLine(stackBaseOnObect.Peek());

            Console.ReadLine();
        }
    }
}
