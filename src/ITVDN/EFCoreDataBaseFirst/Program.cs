using System;

namespace EFCoreDataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Add nuget Microsoft.EntityFrameworkCore.SQLServer
            // 2. Add nuget Microsoft.EntityFrameworkCore.Tools
            // 3. Add nuget Microsoft.EntityFrameworkCore.Design
            // 4. Add nuget Microsoft.EntityFrameworkCore

            // 5. Enter command Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB; Database=Test; Trusted_Connection=true;" Microsoft.EntityFrameworkCore.SqlServer 

            using (TestContext testContext = new TestContext())
            {
                var list = testContext.Customers;

                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Id} - {item.Name1}");
                }
            }

            using (TestContext context = new TestContext())
            {
                Customer customer = new Customer() { Name1 = "Marry" };

                context.Add(customer);
                //context.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}
