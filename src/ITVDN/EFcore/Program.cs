using EFcoreCodeFirst.Context;
using EFcoreCodeFirst.Entities;

namespace EFcoreCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Add nuget Microsoft.EntityFrameworkCore.SQLServer
            // 2. Add nuget Microsoft.EntityFrameworkCore.Tools
            // 3. Create data model 
            // 4. Create class data context 

            // 8. Run command Add-Migration Init
            // The database will not appear
            // 9. Update-Database 

            // 10. Add data in DataBAse
            using (AppContext context = new AppContext())
            {
                context.Users.Add(new User() { Name = "Illia", Age = 30});
                context.SaveChanges();
            }
        }
    }
}
