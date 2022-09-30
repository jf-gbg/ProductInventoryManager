using ProductInventoryManager.UI;
using ProductInventoryManager.Inventory;
using System.Reflection;

Product product = new Product(1, "Strat", 1000m, 10);
List<Product> products = new List<Product>();

Product testProduct = ProductFactory.CreateProduct();

testProduct = ProductFactory.UpdateProduct(testProduct);


