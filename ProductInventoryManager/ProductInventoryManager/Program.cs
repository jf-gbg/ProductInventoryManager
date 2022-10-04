using System.Reflection;
using ProductInventoryManager.InventoryDomain;
using ProductInventoryManager.Ui;
using ProductInventoryManager.Data;

using (InventoryContext context = new InventoryContext())
{
    context.Database.EnsureCreated();
}

Warehouse mainWarehouse = new Warehouse();

ProductFactory.CreateProduct(mainWarehouse, UiUtilities.WriteAndReadConsole(UiText.ProductCreation()));
ProductFactory.CreateProduct(mainWarehouse, UiUtilities.WriteAndReadConsole(UiText.ProductCreation()));

foreach (Product product in mainWarehouse.Products)
{
    UiUtilities.WriteToConsole(UiText.ProductInfo(product));
}



