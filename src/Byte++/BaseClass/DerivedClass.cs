using System;

namespace BaseClass
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {
            Console.WriteLine($"Constructor BaseClass without param\n {Firm}, {Matireal} DerivedClass");
        }

        public DerivedClass(string firm, string material) : base(firm, material)
        {
            Console.WriteLine($"Constructor BaseClass with param 2 type string DerivedClass {firm}, {material}");
        }
    }
}
