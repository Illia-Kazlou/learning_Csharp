using System;

namespace Metanit_Polymorthism
{
    public class Employee : Person  
    {
        public string Company { get; set; }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        public override void Display()
        {
            Console.WriteLine($"He works in {Company}");
        }
    }
}
