using System;

namespace CourseHunter_69_Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character Elf = new Character("Elf");
            Console.WriteLine($"{Elf.Race}, {Elf.Armor}");

            Character Human = new Character("Human", 15 );
            Console.Write(Human.Race);
            Console.WriteLine(Human.Armor);

            Character Orc = new Character("Orc", 20);
            Console.WriteLine($"{Orc.Race}, {Orc.Armor}");

            Character Dwarf = new Character("Dwarf", 21, 120);
            Console.WriteLine($"{Dwarf.Race}, {Dwarf.Armor}, {Dwarf.Health}");
            Console.ReadLine();
        }
    }
}
