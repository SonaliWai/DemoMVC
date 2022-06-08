using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Models
{
    public class userManagementContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-L2HUVOJB;Initial Catalog=UserManagement;Integrated Security=True");
        }
    }
}
