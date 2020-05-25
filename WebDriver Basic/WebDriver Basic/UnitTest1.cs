using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace WebDriver_Basic
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("localhost:5000");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7));
        }   
        [Test]
        public void LoginTest()
        {
            Login();
        }
        [Test]
        public void AddProduct()
        {
            Login();
            driver.FindElement(By.XPath("//ul//a[@href=\"/Product\"]")).Click();
            driver.FindElement(By.CssSelector("a.btn.btn-default")).Click();
            driver.FindElement(By.CssSelector("input#ProductName")).SendKeys("TestProduct");
            driver.FindElement(By.CssSelector("select#CategoryId")).SendKeys(("Produce"));
            driver.FindElement(By.CssSelector("select#SupplierId")).SendKeys(("Tokyo Traders"));
            driver.FindElement(By.CssSelector("input#UnitPrice")).SendKeys(("12"));
            driver.FindElement(By.CssSelector("input#QuantityPerUnit")).SendKeys(("10"));
            driver.FindElement(By.CssSelector("input#UnitsInStock")).SendKeys(("13"));
            driver.FindElement(By.CssSelector("input#UnitsOnOrder")).SendKeys(("11"));
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            Assert.AreNotEqual("Product editing", driver.FindElement(By.CssSelector("h2")).Text);
        }
        [Test]
        public void LogoutTest()
        {
            Login();
            driver.FindElement(By.XPath("//ul//a[@href=\"/Account/Logout\"]")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//input[@Name]")));
            Assert.AreEqual("Login", driver.FindElement(By.CssSelector("h2")).Text);
        }
        private void Login()
        {
            driver.FindElement(By.XPath("//input[@Name]")).SendKeys("user");
            driver.FindElement(By.CssSelector("input#Password")).SendKeys("user");
            driver.FindElement(By.CssSelector("input.btn.btn-default")).Click();
            Assert.AreEqual("Home page", driver.FindElement(By.CssSelector("h2")).Text);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}