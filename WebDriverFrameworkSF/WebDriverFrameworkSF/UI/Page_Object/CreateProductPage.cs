using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Work5
{
    class CreateProductPage
    {
        private IWebDriver driver;

        public CreateProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        int numberCategory;
        int numberSupplier;
        private IWebElement ProductNameInput => driver.FindElement(By.XPath("//input[contains(@id,\"ProductName\")]"));

        private IWebElement CategoryName => driver.FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]")).FindElement(By.XPath($"//select[contains(@id,\"CategoryId\")]/option[@value=\"{numberCategory}\"]"));


        private IWebElement SupplierName => driver.FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]")).FindElement(By.XPath($"//select[contains(@id,\"SupplierId\")]/option[@value=\"{numberSupplier}\"]"));

        private IWebElement UnitPriceCost => driver.FindElement(By.XPath("//input[contains(@id,\"UnitPrice\")] "));

        private IWebElement QuantityPerUnitNumber => driver.FindElement(By.XPath("//input[contains(@id,\"QuantityPerUnit\")] "));

        private IWebElement UnitsInStockNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsInStock\")] "));

        private IWebElement UnitsOnOrderNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsOnOrder\")] "));

        private IWebElement ReorderLevelNumber => driver.FindElement(By.XPath("//input[contains(@id,\"ReorderLevel\")] "));

        private IWebElement DiscontinuedTrue => driver.FindElement(By.XPath("//input[contains(@id,\"Discontinued\")] "));


        private IWebElement CreateButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));



        public CreateProductPage InputProduct(Products product)
        {


            ProductNameInput.SendKeys(product.nameProduct);

            UnitPriceCost.SendKeys(product.costUnitPrice);
            QuantityPerUnitNumber.SendKeys(product.numberQuantityPerUnit);
            UnitsInStockNumber.SendKeys(product.numberUnitsInStock);
            UnitsOnOrderNumber.SendKeys(product.numberUnitsOnOrder);
            ReorderLevelNumber.SendKeys(product.numberReorderLevel);
            DiscontinuedTrue.Click();

            return this;

        }


        public CreateProductPage CategorySupplierClick(int numberCategory, int numberSupplier)
        {
            this.numberCategory = numberCategory;
            CategoryName.Click();

            this.numberSupplier = numberSupplier;
            SupplierName.Click();
            return this;
        }

        public AllProductsPage ClickCreateButton()
        {
            new Actions(driver).Click(CreateButton).Build().Perform();
            return new AllProductsPage(driver);
        }

    }
}
