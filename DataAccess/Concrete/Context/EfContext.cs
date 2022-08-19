using Entities.Concrete;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=TakiToka_DB;Trusted_Connection=True;");
        }
        public DbSet<User>Users { get; set; }
        public DbSet<Product>Products  { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Customer>Customers { get; set; }
    }
}
 

