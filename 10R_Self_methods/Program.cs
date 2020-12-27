using System;

namespace _10R_Self_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region writeread
            //Console.WriteLine("Are you nuts1");
            //string name = Console.ReadLine();
            //int age = Convert.ToInt32(Console.ReadLine());
            //var i = PrintHello(name, age);
            //Console.WriteLine(i);
            //Console.ReadLine();
            #endregion

            //var person1 = new Person("illia", "kozlov");
            //var person2 = new Person("James", "Bond");

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(person1.Run());

            //    //или так, ЛУЧШЕ ТАК
            //    var position2 = person2.Run();
            //    Console.WriteLine(position2);
            //}

            Console.WriteLine(Factorial(3));

            Console.ReadLine();
        }

        //рекурсия, вызов метода внутри себя
        public static int Factorial(int value)
        {
            if (value <=1 )
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }

        //модификатиор_доступа тип_возвращаемого_значения имя_метода(тип_аргумента1 имя_аргумента1, тип_аргумента2 имя_аргумента2)
        //{
        //    тело метода;
        //}

        #region method_PrintHello
        //public static int PrintHello(string name, int age)
        //{
        //    Console.WriteLine($"Hello {name}. You {age} y.o");
        //    return 1;
        //}
        #endregion

    }
}
