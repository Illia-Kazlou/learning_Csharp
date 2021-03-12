using System;

namespace CourseHunter_80_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            StackBaseOnObect<int> stackBaseOnObect = new StackBaseOnObect<int>();
            stackBaseOnObect.Push(1);
            stackBaseOnObect.Push(3);
            stackBaseOnObect.Push(2);

            //System.Collections.IEnumerable equatable = (System.Collections.IEnumerable)stackBaseOnObect;
            //equatable.GetEnumerator(); // -------> вот так мы можем вызвать необощенный !!!!

            // Допустим у нас есть похожие классы  и мы хотим использовать foreach.
            ///foreach (var item in stackBaseOnObect)
            ///{
            ///}
            // В данном случае мы не можем использовать foreach, так как это просто экземпляр класса.
            // Для того что бы это работало нам необходимо в классе реализоватиь интерфейс IEnumerble.-------> Неправильное суждение, но ести и другой спосод

            //while (stackBaseOnObect.Count != 0)
            //{
            //    Console.WriteLine(stackBaseOnObect.Peek());
            //    stackBaseOnObect.Pop();
            //}

            foreach (var item in stackBaseOnObect)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
