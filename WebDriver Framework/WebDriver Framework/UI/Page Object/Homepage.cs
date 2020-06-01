using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFramework
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement AllProductsButton => driver.FindElement(By.XPath("//div/a[@href=\"/Product\"]"));
        private IWebElement LogoutButton => driver.FindElement(By.XPath("//a[@href=\"/Account/Logout\"]"));
        private IWebElement Headline => driver.FindElement(By.XPath("//h2"));
        public ProductsPage AllProductView()
        {
            AllProductsButton.Click();
            return new ProductsPage(driver);
        }
        public HomePage LogoutCheck()
        {
            new Actions(driver).Click(LogoutButton).Build().Perform();
            return new HomePage(driver);
        }
        public string GetHeadline()
        {
            return Headline.Text;
        }
    }
}
