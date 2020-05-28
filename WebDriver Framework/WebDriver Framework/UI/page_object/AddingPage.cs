using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;
using WebDriver_Basic.Business_object;

namespace WebDriver_Basic
{
    class AddingPage
    {
        private IWebDriver driver;
        public AddingPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        string firstLast, secondLast;

        private IWebElement allProductsLink => driver.FindElement(By.XPath("//ul//a[@href=\"/Product\"]"));
        private IWebElement createNewButton => driver.FindElement(By.CssSelector("a.btn.btn-default"));
        private IWebElement productInput => driver.FindElement(By.CssSelector("input#ProductName"));
        private IWebElement categorySelect => driver.FindElement(By.CssSelector("select#CategoryId"));
        private IWebElement supplierSelect => driver.FindElement(By.CssSelector("select#SupplierId"));
        private IWebElement unitPriceInput => driver.FindElement(By.CssSelector("input#UnitPrice"));
        private IWebElement quantityPerUnitInput => driver.FindElement(By.CssSelector("input#QuantityPerUnit"));
        private IWebElement unitInStockInput => driver.FindElement(By.CssSelector("input#UnitsInStock"));
        private IWebElement unitsOnOrderInput => driver.FindElement(By.CssSelector("input#UnitsOnOrder"));
        private IWebElement sendButton => driver.FindElement(By.CssSelector("input.btn.btn-default"));
        private IWebElement textElement => driver.FindElement(By.CssSelector("h2"));
        private IWebElement firstlast => driver.FindElement(By.XPath(".//*[@class='table']/tbody/tr[last()]"));
        private IWebElement secondlast => driver.FindElement(By.XPath(".//*[@class='table']/tbody/tr[last()]"));

        public void Adding(Products testProduct)
        {
            new Actions(driver).Click(allProductsLink).Build().Perform();
            firstLast = Convert.ToString(firstlast.GetHashCode());
            new Actions(driver).Click(createNewButton).Build().Perform();
            new Actions(driver).Click(productInput).SendKeys(testProduct.productName).Build().Perform();
            new Actions(driver).Click(categorySelect).SendKeys(testProduct.categoryName).Build().Perform();
            new Actions(driver).Click(supplierSelect).SendKeys(testProduct.supplierName).Build().Perform();
            new Actions(driver).Click(unitPriceInput).SendKeys(testProduct.unitPrice).Build().Perform();
            new Actions(driver).Click(quantityPerUnitInput).SendKeys(testProduct.quantityPerUnit).Build().Perform();
            new Actions(driver).Click(unitInStockInput).SendKeys(testProduct.unitInStock).Build().Perform();
            new Actions(driver).Click(unitsOnOrderInput).SendKeys(testProduct.unitInOrder).Build().Perform();
            new Actions(driver).Click(sendButton).Build().Perform();
            new Actions(driver).Click(secondlast).Build().Perform();
            new Actions(driver).Click(allProductsLink).Build().Perform();
            secondLast = Convert.ToString(secondlast.GetHashCode());
            Thread.Sleep(2000);


        }
        public string GetTextElementValue()
        {
            return textElement.Text;
        }

        public string CheckingBefore()
        {

            return firstLast;
            
        }

       public string CheckingAfter()
        {
            return secondLast;
        }
    }
}
