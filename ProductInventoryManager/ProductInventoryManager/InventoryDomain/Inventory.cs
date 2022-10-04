using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManager.InventoryDomain
{
    public class Warehouse
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }

        public Warehouse()
        {
            Products = new List<Product>();
        }
    }
}
