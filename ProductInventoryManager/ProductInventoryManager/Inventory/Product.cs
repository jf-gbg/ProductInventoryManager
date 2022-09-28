using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManager.Inventory
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(int id, string name, decimal price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void WriteProductInfo()
        {
            Console.WriteLine($"---Product Info---\n" +
                $"ID: {Id}\n" +
                $"Name: {Name}\n" +
                $"Price(kr): {Math.Round(Price, MidpointRounding.AwayFromZero)}\n" +
                $"Quantity in stock: {Quantity}\n" +
                $"---------------------");
        }
    }
}
