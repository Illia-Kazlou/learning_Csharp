using System;
using System.IO;

namespace CourseHunter_83_MyselfException
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character Elf = new Character("Elf", 10);
            Console.WriteLine($"{Elf.Race}, {Elf.Armor}");

            Character Human = new Character("Human", 15 );
            Console.Write(Human.Race);
            Console.WriteLine(Human.Armor);

            Character Orc = new Character("Orc", 20);
            Console.WriteLine($"{Orc.Race}, {Orc.Armor}");

            Character Dwarf = new Character("Dwarf", 21, 120);
            Console.WriteLine($"{Dwarf.Race}, {Dwarf.Armor}, ");
            Console.ReadLine();

            Console.WriteLine(new string ('_', 40));

            Console.WriteLine($@"{Directory.GetCurrentDirectory()}\");

            //LocalFileSystemStorage localFileSystemStorage = new LocalFileSystemStorage(1);

            //Console.WriteLine(localFileSystemStorage.IsFileExistInStorage("1.txt"));


            Console.ReadLine();

        }
    }
}
