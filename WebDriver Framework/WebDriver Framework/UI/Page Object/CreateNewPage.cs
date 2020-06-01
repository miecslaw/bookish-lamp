using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WebDriverFramework.Business_object;

namespace WebDriverFramework
{
    class CreateNewPage
    {
        private IWebDriver driver;
        public CreateNewPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement ProductNameInput => driver.FindElement(By.XPath("//input[contains(@id,\"ProductName\")]"));
        private IWebElement CategoryName => driver.FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]")).FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]/option[@value=\"3\"]"));
        private IWebElement SupplierName => driver.FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]")).FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]/option[@value=\"26\"]"));
        private IWebElement UnitPriceCost => driver.FindElement(By.XPath("//input[contains(@id,\"UnitPrice\")] "));
        private IWebElement QuantityPerUnitNumber => driver.FindElement(By.XPath("//input[contains(@id,\"QuantityPerUnit\")] "));
        private IWebElement UnitsInStockNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsInStock\")] "));
        private IWebElement UnitsOnOrderNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsOnOrder\")] "));
        private IWebElement SendButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));
        public ProductsPage InputProduct(Products product)
        {
            ProductNameInput.SendKeys(product.productName);
            CategoryName.Click();
            SupplierName.Click();
            UnitPriceCost.SendKeys(product.unitPrice);
            QuantityPerUnitNumber.SendKeys(product.quantityPerUnit);
            UnitsInStockNumber.SendKeys(product.unitsInStock);
            UnitsOnOrderNumber.SendKeys(product.unitsInOrder);
            new Actions(driver).Click(SendButton).Build().Perform();
            return new ProductsPage(driver);
        }
    }
}
