using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDomain
{
    public class Inventory
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }

        public Inventory()
        {
            Products = new List<Product>();
        }
    }
}
