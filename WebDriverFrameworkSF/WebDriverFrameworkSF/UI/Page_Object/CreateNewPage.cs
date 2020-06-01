using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebDriverFrameworkSF.UI.Page_Object
{
    class CreateNewPage
    {
        private IWebDriver driver;
        public CreateNewPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        int category;
        int supplier;
        private IWebElement ProductName => driver.FindElement(By.XPath("//input[contains(@id,\"ProductName\")]"));
        private IWebElement CategoryName => driver.FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]")).FindElement(By.XPath($"//select[contains(@id,\"CategoryId\")]/option[@value=\"{category}\"]"));
        private IWebElement SupplierName => driver.FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]")).FindElement(By.XPath($"//select[contains(@id,\"SupplierId\")]/option[@value=\"{supplier}\"]"));
        private IWebElement UnitPrice => driver.FindElement(By.XPath("//input[contains(@id,\"UnitPrice\")] "));
        private IWebElement QuantityPerUnit => driver.FindElement(By.XPath("//input[contains(@id,\"QuantityPerUnit\")] "));
        private IWebElement UnitsInStock => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsInStock\")] "));
        private IWebElement UnitsOnOrder => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsOnOrder\")] "));
        private IWebElement CreateButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));



        public CreateNewPage InputProduct(Products product)
        {
            ProductName.SendKeys(product.productName);
            UnitPrice.SendKeys(product.unitPrice);
            QuantityPerUnit.SendKeys(product.quantityPerUnit);
            UnitsInStock.SendKeys(product.unitsInStock);
            UnitsOnOrder.SendKeys(product.unitsOnOrder);
            return this;
        }


        public CreateNewPage CategorySupplierClick(int category, int supplier)
        {
            this.category = category;
            CategoryName.Click();

            this.supplier = supplier;
            SupplierName.Click();
            return this;
        }

        public ProductsPage ClickCreateButton()
        {
            new Actions(driver).Click(CreateButton).Build().Perform();
            return new ProductsPage(driver);
        }

    }
}
