using System;

namespace Metanit_Polymorthism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan");
            //Console.WriteLine(person.Name);
            person.Display();

            Employee employee = new Employee("Inokentiy", "Bad programmer");
            //Console.WriteLine(employee.Name , employee.Company);
            employee.Display();

            Console.ReadLine();
        }
    }
}
