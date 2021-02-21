using System;

namespace CourseHunter_61_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Методы уровня класса вызваются только при создании экземпляра класса, т.е. эти методы свойственны только данному классу.
            // Дорустим, чтобы воспользоваться классом MAth нам не надо создовать экземпляр класса, вот бля этого и нужен статический класс или статический метод.
            // МЫСЛИ. Это наверное надо для того если нас не интересует создание какого-то объекта с которым надо далее будет работать, 
            // а для просто использования функционала либо еще чего нибубь в статическом объекте

            Console.WriteLine(Calculator.Average2(12, 13, 14));

            //При этом если мы все же объявим экземпляр класса. Статические методы в нем не будут доступны. Например.
            Calculator calc = new Calculator();
            double d = calc.Average(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Console.WriteLine(d);

            Console.WriteLine(new string ('_', 30));

            Character c1 = new Character();
            Character c2 = new Character();

            //Статические поля так и статические свойсва будут принадлежать не просто экземпляру класса а всему классу.
            // Помять на статическое поле и сойсвто выделяется один раз в самом начален и может быть далее измениною
            Console.WriteLine($"c1{c1.PrintSpeed()};  c2{c2.PrintSpeed()}");  //output 10 10

            c1.IncreedSpeed();

            Console.WriteLine($"c1{c1.PrintSpeed()};  c2{c2.PrintSpeed()}"); //output 20 20

            Console.ReadLine();
        }
    }
}
