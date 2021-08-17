using System;

namespace BaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string firm = "Zeus";

            string matireal = "Steel";


            DerivedClass derivedClass = new DerivedClass();

            DerivedClass derivedClass1 = new DerivedClass(firm, matireal);

            Console.ReadLine();
        }
    }
}
