using Microsoft.EntityFrameworkCore;

namespace AoCP.Models.DataBaseModel
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Landlord> Landlords { get; set; } = null!;
        public DbSet<Renter> Renters { get; set; } = null!;
        public DbSet<Feedbacks> Feedbacks { get; set; } = null!;
        public DbSet<Object> Object { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=178.170.193.230;user=root;password=Sji-quV-5Mm-XPv;database=aocp;",
                new MySqlServerVersion(new Version(5, 7, 28)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
