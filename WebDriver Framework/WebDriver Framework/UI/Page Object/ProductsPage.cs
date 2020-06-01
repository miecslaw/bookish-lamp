using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebDriverFramework
{
    class ProductsPage
    {
        private IWebDriver driver;
        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private string productvalue;
        private IWebElement CreateNewButton => driver.FindElement(By.XPath("//a[@class=\"btn btn-default\"]"));
        private IWebElement productName => driver.FindElement(By.XPath($"//td[contains(a,\"{productvalue}\")]/a"));
        private IWebElement categoryName => driver.FindElement(By.XPath($"//td[contains(a,\"{productvalue}\")]/following-sibling::td[1]"));
        private IWebElement supplier => driver.FindElement(By.XPath($"//td[contains(a,\"{productvalue}\")]/following-sibling::td[2]"));
        private IWebElement unitPrice => driver.FindElement(By.XPath($"//td[contains(a,\"{productvalue}\")]/following-sibling::td[4]"));
        private IWebElement quantityPerUnit => driver.FindElement(By.XPath($"//td[contains(a,\"{productvalue}\")]/following-sibling::td[3]"));
        private IWebElement unitsInStock => driver.FindElement(By.XPath($"//td[contains(a,\"{productvalue}\")]/following-sibling::td[5]"));
        private IWebElement unitsOnOrder => driver.FindElement(By.XPath($"//td[contains(a,\"{productvalue}\")]/following-sibling::td[6]"));
        public CreateNewPage createNewButtonClick()
        {
            new Actions(driver).Click(CreateNewButton).Build().Perform();
            return new CreateNewPage(driver);
        }
        public string GetProductName(string productvalue)
        {
            this.productvalue = productvalue;
            return productName.Text;
        }
        public string GetCategoryName(string productvalue)
        {
            this.productvalue = productvalue;
            return categoryName.Text;
        }
        public string GetSupplierName(string productvalue)
        {
            this.productvalue = productvalue;
            return supplier.Text;
        }
        public string GetUnitPrice(string productvalue)
        {
            this.productvalue = productvalue;
            return unitPrice.Text;
        }
        public string GetQuantityPerUnit(string productvalue)
        {
            this.productvalue = productvalue;
            return quantityPerUnit.Text;
        }
        public string GetUnitInStock(string productvalue)
        {
            this.productvalue = productvalue;
            return unitsInStock.Text;
        }
        public string GetUnitsOnOrder(string productvalue)
        {
            this.productvalue = productvalue;
            return unitsOnOrder.Text;
        }
    }
}