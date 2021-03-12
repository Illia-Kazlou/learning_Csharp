using System;

namespace CourseHunter_79_Self_StackOnGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            StackBaseOnObect<int> stackBaseOnObect = new StackBaseOnObect<int>();
            stackBaseOnObect.Push(1);
            stackBaseOnObect.Push(3);
            stackBaseOnObect.Push(2);
            stackBaseOnObect.Push('r'); // здесь находится его цифровая реализация

            // Invalid cast exeption
            while (stackBaseOnObect.Count != 0)
            {
                Console.WriteLine(stackBaseOnObect.Peek());
                stackBaseOnObect.Pop();
            }


            //Console.WriteLine(stackBaseOnObect.Peek());

            //stackBaseOnObect.Pop();

            //Console.WriteLine(stackBaseOnObect.Peek());

            Console.ReadLine();
        }
    }
}
