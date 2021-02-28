using System;

namespace CourseHunter_70_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankTerminal bankTerminal = new BankTerminal("+21425+");
            bankTerminal.Connect();

            ModelXTermonal modelXTermonal = new ModelXTermonal("+214257+");
            modelXTermonal.Connect();

            ModelYTermonal modelYTermonal = new ModelYTermonal("+213565+");
            modelYTermonal.Connect();

            Console.ReadLine();
        }
    }
}
