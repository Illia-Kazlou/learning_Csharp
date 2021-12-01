using System;

namespace Metanit_Polymorthism
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine(Name);
        }
    }
}
