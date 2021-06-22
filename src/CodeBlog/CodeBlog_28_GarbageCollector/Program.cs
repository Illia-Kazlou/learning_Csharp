using System;

namespace CodeBlog_28_GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GC.Collect(4); //Вызов сборщика мусора
                var memory = GC.GetTotalMemory(false);
                Console.WriteLine($"{memory}");

                for (int i = 0; i < 10000; i++)
                {
                    var obj = (object)i;
                    var j = (int)obj;
                }

                Console.WriteLine(new string ('_',15));
                Console.WriteLine(GC.GetTotalMemory(false));

                Console.WriteLine(new string('_', 15));
                GC.Collect();
                Console.WriteLine(GC.GetTotalMemory(false));
            }
            catch (Exception)
            {
                Console.WriteLine("No 4");
                throw;
            }

            using (var c = new MyClass()) // юсинг работает так как MyClass реализует интерфейс IDisposible
            {

            }


            Console.ReadLine();
        }
    }
}
