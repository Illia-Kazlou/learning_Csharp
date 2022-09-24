using System;

namespace MySelf_OperatorYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            foreach (int item in product)
            {
                Console.WriteLine(item);
            }

            Company microsoft = new Company(new Person[] { new Person("Elijah"), new Person("Max") });

            foreach (var employee in microsoft)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
