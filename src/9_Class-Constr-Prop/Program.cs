using System;


namespace _9_Class_Constr_Prop
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Name = "Nick";
            p.SecondName = " Bond";

            Console.WriteLine(p.Name+p.SecondName);

            Console.WriteLine(p.FullName);

            Console.WriteLine(p.ShortName);

            //p.SetName("Micke");
            //Console.WriteLine(p.GetName());

            Console.ReadLine();
        }
    }
}
