using System;

namespace CourseHunter_71_Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape [2];
            shapes[0] = new Triangle(10, 20, 30);
            shapes[1] = new Recanlge(10, 20);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
                Console.WriteLine(shape.Preimeter());


            }
            


            Console.WriteLine(new string ('_', 35));

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
