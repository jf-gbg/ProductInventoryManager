using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ProductInventoryManager.Ui;

namespace ProductInventoryManager.InventoryDomain
{
    internal class ProductFactory
    {
        public static Product CreateProduct(Warehouse inventory, string[] productDetails)
        {
            Product newProduct = new Product();
            newProduct.Name = productDetails[0];
            newProduct.Price = Decimal.Parse(productDetails[1]);
            newProduct.Quantity = int.Parse(productDetails[2]);
            AddProductToInventory(inventory, newProduct);

            return newProduct;
        }

        internal static void AddProductToInventory(Warehouse inventory, Product product)
        {
            inventory.Products.Add(product);
        }

        public static Product UpdateProduct(Product productToEdit)
        {
            string[] newProductDetails = UiUtilities.WriteAndReadConsole(UiText.EditProduct());

            productToEdit.Name = newProductDetails[0];
            productToEdit.Price = decimal.Parse(newProductDetails[1]);

            return productToEdit;
        }
    }
}
