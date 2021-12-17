using System;

namespace Metanit_IEnumerable
{
    class Program
    {
        /// <summary>
        /// В примерах выше использовались необобщенные версии интерфейсов, однако мы также можем использовать их обобщенные двойники
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Week week = new Week();

            // 2. И для того что бы использовать оператор FOREACH на своей новой колекции нам необходимо 
            // в классе определить публичный метод GetEnumerator, который бы возвращал объект IEnumerator
            foreach (var day in week)
            {
                Console.WriteLine(day);
            } 

            Console.ReadLine();
        }
    }
}
