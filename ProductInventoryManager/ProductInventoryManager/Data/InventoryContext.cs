using Microsoft.EntityFrameworkCore;
using ProductInventoryManager.InventoryDomain;

namespace ProductInventoryManager.Data
{
    public class InventoryContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Inventories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = InventoryDatabase");
        }
    }
}