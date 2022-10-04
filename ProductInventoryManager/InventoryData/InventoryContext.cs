using InventoryDomain;
using Microsoft.EntityFrameworkCore;

namespace InventoryData
{
    public class InventoryContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DataSource = (localdb)\\MSSQLLocalDB; Initial Catalog = PubDatabase");
        }
    }
}