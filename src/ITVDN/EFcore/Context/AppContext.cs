using EFcoreCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFcoreCodeFirst.Context
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; } // 5. Storage entities and link whith tables.

        // 6. Override method OnConfigure
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 7. Row connection link
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=EFCoreITVDN; Trusted_Connection=True"); 
            // Server Name, DataBase Name, use administration user root
        }
    }
}
