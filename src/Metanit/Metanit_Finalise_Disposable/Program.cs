using System;

namespace Metanit_Finalise_Disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.ReadLine();

            // Обратите внимание, что даже после завершения метода Test и соответственно
            // удаления из стека ссылки на объект Person в куче, может не последовать немедленного вызова деструктора.
            // Лишь при завершении всей программы гарантировано произойдет очистка памяти и вызов деструктора. 
            // Поэтому для более быстой очистки памяти применяется метод GC.Collect.

        }
        private static void Test()
        {
            Person p = new Person();
        }
    }
}
