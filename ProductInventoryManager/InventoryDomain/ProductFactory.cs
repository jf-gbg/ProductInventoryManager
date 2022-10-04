using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDomain
{
    internal class ProductFactory
    {
        public static Product CreateProduct()
        {
            string[] productDetails = UiUtilities.WriteAndReadConsole(UiText.ProductCreation());
            Product product = new Product(1, productDetails[0], Decimal.Parse(productDetails[1]), int.Parse(productDetails[2]));

            return product;
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
