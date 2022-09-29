using ProductInventoryManager.Inventory;

namespace ProductInventoryManager.Tests
{
    public class InventoryUtilitiesTests
    {
        Product strat = new Product(1, "Strat", 1000m, 1);
        Product tele = new Product(2, "Tele", 1000m, 13);
        Product jBass = new Product(3, "JBass", 1200m, 8);
        Product pBass = new Product(4, "pBass", 1200m, 11);
        private List<Product> products = new List<Product>();

        private void PopulateProducts()
        {
            products.Add(strat);
            products.Add(tele);
            products.Add(jBass);
            products.Add(pBass);
        }

        [Fact]
        public void GetInventoryTotal_Returns_AccurateTotal()
        {
            //Arrange
            products.Add(strat);
            int testInventoryTotal = strat.Quantity;

            //Act
            int utilityReturnTotal = InventoryUtilities.GetInventoryTotal(products);

            //Assert
            Assert.Equal(testInventoryTotal, utilityReturnTotal);
        }

        [Fact]
        public void GetCurrentInventoryValue_Returns_AccurateValue()
        {
            products.Add(strat);
            decimal testInventoryValue = strat.Quantity * strat.Price;

            decimal utilityReturnValue = InventoryUtilities.GetCurrentInventoryValue(products);

            Assert.Equal(testInventoryValue, utilityReturnValue);
        }


    }
}