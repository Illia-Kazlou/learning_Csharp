using System;

namespace MySelf_Inherit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(1,"Opel", "Blue", "MidDle", 220);
            var apple = new Apple(1, "Apple", "Red", "small", "Very testy");

            Console.WriteLine($"{car.Name}, {car.Color}, {car.Speed}");
            Console.WriteLine($"{apple.Name}, {apple.Color}, {apple.Testy}");

            Console.ReadLine();
        }
    }
}
