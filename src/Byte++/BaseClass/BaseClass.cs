using System;

namespace BaseClass
{
    public class BaseClass
    {
        public string Firm { get; set; } = "Firm unknown";

        public string Matireal { get; set; } = "Matireal unknown";

        public BaseClass()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('=', 40));
            Console.WriteLine($"Constructor BaseClass without param\n {Firm}, {Matireal} ");
            Console.WriteLine(new string('=', 40));
            Console.ForegroundColor = ConsoleColor.White;
        }

        public BaseClass(string firm, string material)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Constructor BaseClass with param 2 type string");
            Console.WriteLine(new string('=', 40));
            Firm = firm;
            Matireal = material;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
