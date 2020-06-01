using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFrameworkSF.UI.Page_Object
{
    class ProductsPage
    {
        private IWebDriver driver;

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private string NameCreateProduct;

        private IWebElement CreateNewProductButton => driver.FindElement(By.XPath("//a[@class=\"btn btn-default\"]"));

        private IWebElement productName => driver.FindElement(By.XPath($"//td[contains(a,\"{NameCreateProduct}\")]/a"));


        private IWebElement categoryName => driver.FindElement(By.XPath($"//td[contains(a,\"{NameCreateProduct}\")]/following-sibling::td[1]"));

        private IWebElement supplierName => driver.FindElement(By.XPath($"//td[contains(a,\"{NameCreateProduct}\")]/following-sibling::td[2]"));

        private IWebElement unitPrice => driver.FindElement(By.XPath($"//td[contains(a,\"{NameCreateProduct}\")]/following-sibling::td[4]"));

        private IWebElement quantityPerUnit => driver.FindElement(By.XPath($"//td[contains(a,\"{NameCreateProduct}\")]/following-sibling::td[3]"));

        private IWebElement unitInStock => driver.FindElement(By.XPath($"//td[contains(a,\"{NameCreateProduct}\")]/following-sibling::td[5]"));

        private IWebElement unitsOnOrderProduct => driver.FindElement(By.XPath($"//td[contains(a,\"{NameCreateProduct}\")]/following-sibling::td[6]"));

        public CreateNewPage createButtonClick()
        {
            new Actions(driver).Click(CreateNewProductButton).Build().Perform();
            return new CreateNewPage(driver);
        }

        public string GetProductName(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return productName.Text;
        }
        public string GetCategoryName(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return categoryName.Text;
        }
        public string GetSupplierName(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return supplierName.Text;
        }
        public string GetUnitPrice(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return unitPrice.Text;
        }
        public string GetQuantityPerUnit(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return quantityPerUnit.Text;
        }
        public string GetUnitInStock(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return unitInStock.Text;
        }
        public string GetUnitsOnOrderText(string NameCreateProduct)
        {
            this.NameCreateProduct = NameCreateProduct;
            return unitsOnOrderProduct.Text;
        }
    }
}
