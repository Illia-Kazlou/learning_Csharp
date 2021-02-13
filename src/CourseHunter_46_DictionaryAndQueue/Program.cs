using System;
using System.Collections.Generic;

namespace CourseHunter_46_StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack2 = new Stack<int>(); 
            // или(зачастую используется второй вариант)
            var stack = new Stack<int>(); 
            
            // как пример во многих программах и в операционных системах при нажатии ctrl+Z отмена операции, это и есть стек хранения методов программы.
            stack.Push(2); // метод добавленеия в очередь.
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            Console.WriteLine($"Should print out {stack.Peek()}"); // метод просмотра крайнего элемента. 

            stack.Pop();
            Console.WriteLine($"Should print out {stack.Peek()}");

            Console.WriteLine("Iterate over the stack.");

            foreach (var item in stack)
            {
                Console.Write(item + "-->");
            }
            Console.WriteLine("\n");
            Console.WriteLine(new string ('-', 40));

            var queue = new Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            Console.WriteLine($"Operaiton Peek {queue.Peek()}");

            queue.Dequeue();
            Console.WriteLine($"After operation Dequeue {queue.Peek()}");

            foreach (var item in queue)
            {
                Console.Write($"{item} -->");
            }


            Console.ReadKey();
        }
    }
}
