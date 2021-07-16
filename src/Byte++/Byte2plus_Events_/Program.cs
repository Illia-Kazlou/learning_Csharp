using System;

namespace Byte2plus_Events_
{
    class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Оброботчик событитя 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Handler event 2");
        }

        static void Main(string[] args)
        {
            MyClass instanse = new MyClass();

            // подписка на событие
            instanse.myEvent += new EventDelegate(Handler1); //  техника предположения делегата
            instanse.myEvent += Handler2;

            Console.WriteLine(new string('-', 40));

            //instanse.myEvent -= new EventDelegate(Handler2);

            instanse.InvokeEvent();


            Console.ReadLine();
        }
    }
}
