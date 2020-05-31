using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver_Basic;
using WebDriver_Basic.Business_object;
using WebDriver_Basic.Service.UI;

namespace WebDriver_Advanced
{
    public class Tests
    {
        private IWebDriver driver;
        private EnteringPage enteringPage;
        private AddingPage addingPage;
        private MainPage mainPage;
        private Products testProduct = new Products("Test111Product",
                                                    "Produce",
                                                    "Tokyo Traders",
                                                    "2",
                                                    "10",
                                                    "13",
                                                    "11");
        private User testNameAndPassword = new User("user",
                                                   "user");
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("localhost:5000");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void LoginTest()
        {
            enteringPage = ProductsService.Login(testNameAndPassword, driver);
            Assert.AreEqual("Home page", enteringPage.GetTextElementValue());
        }
        [Test]
        public void AddProduct()
        {
            enteringPage = ProductsService.Login(testNameAndPassword, driver);
            addingPage = ProductsService.AddingProduct(testProduct, driver);
            Assert.AreEqual("Test111Product", testProduct.productName);
            Assert.AreEqual("Produce", testProduct.categoryName);
            Assert.AreEqual("Tokyo Traders", testProduct.supplierName);
            Assert.AreEqual("2", testProduct.unitPrice);
            Assert.AreEqual("10", testProduct.quantityPerUnit);
            Assert.AreEqual("13", testProduct.unitInStock);
            Assert.AreEqual("11", testProduct.unitInOrder);
        }

        [Test]
        public void LogoutTest()
        {
            enteringPage = ProductsService.Login(testNameAndPassword, driver);
            mainPage = ProductsService.ClickLogout(driver);
            Assert.AreEqual("Login",mainPage.GetTextElementValue());
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}