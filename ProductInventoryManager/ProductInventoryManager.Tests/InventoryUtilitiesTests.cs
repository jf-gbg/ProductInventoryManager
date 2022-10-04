using ProductInventoryManager.InventoryDomain;


namespace ProductInventoryManager.Tests
{
    public class InventoryUtilitiesTests
    {
        Product strat = new Product("Strat", 1000m, 1);
        Product tele = new Product("Tele", 1000m, 13);
        Product jBass = new Product("JBass", 1200m, 8);
        Product pBass = new Product("pBass", 1200m, 11);
        Warehouse inventory = new Warehouse();

        private void PopulateProducts()
        {
            inventory.Products.Add(strat);
            inventory.Products.Add(tele);
            inventory.Products.Add(jBass);
            inventory.Products.Add(pBass);
        }

        [Fact]
        public void GetInventoryTotal_Returns_AccurateTotal()
        {
            //Arrange
            inventory.Products.Add(strat);
            int testInventoryTotal = strat.Quantity;

            //Act
            int utilityReturnTotal = InventoryUtilities.GetInventoryTotal(inventory.Products);

            //Assert
            Assert.Equal(testInventoryTotal, utilityReturnTotal);
        }

        [Fact]
        public void GetCurrentInventoryValue_Returns_AccurateValue()
        {
            inventory.Products.Add(strat);
            decimal testInventoryValue = strat.Quantity * strat.Price;

            decimal utilityReturnValue = InventoryUtilities.GetCurrentInventoryValue(inventory.Products);

            Assert.Equal(testInventoryValue, utilityReturnValue);
        }

    }
}