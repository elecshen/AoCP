using Microsoft.EntityFrameworkCore;

namespace AoCP.Models.DataBaseModel
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Object> Object { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=178.170.193.230;user=root;password=Sji-quV-5Mm-XPv;database=aocp;",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}
