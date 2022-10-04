using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDomain;

namespace InventoryDomain
{
    public class InventoryUtilities
    {
        public static int GetInventoryTotal(List<Product> products)
        {
            int inventoryTotal = 0;
            foreach (Product product in products)
            { 
                inventoryTotal += product.Quantity;
            }

            return inventoryTotal;
        }

        public static decimal GetCurrentInventoryValue(List<Product> products)
        {
            decimal inventoryValue = 0;
            foreach(Product product in products)
            {
                inventoryValue += product.Quantity * product.Price;
            }

            return inventoryValue;
        }


    }
}
