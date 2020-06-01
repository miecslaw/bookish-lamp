using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverFramework.Business_object;
using WebDriverFramework.ui;

namespace WebDriverFramework

{
    public class Tests
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private ProductsPage productsPage;
        private User testUser = new User("user",
                                         "user");
        private Products newProduct = new Products("TestProduct",
                                                   "12", 
                                                   "10", 
                                                   "13", 
                                                   "5");
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [Test]
        public void TestLogin()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            loginPage = ProductService.Login(testUser, driver);
            Assert.AreEqual("Home page", homePage.GetHeadline());

        }

        [Test]
        public void TestCreateProduct()
        {
            loginPage = new LoginPage(driver);
            productsPage = new ProductsPage(driver);
            loginPage = ProductService.Login(testUser, driver);
            productsPage = ProductService.CreateProduct(newProduct, driver);

            Assert.AreEqual("TestProduct", productsPage.GetProductName(newProduct.productName));
            Assert.AreEqual("Confections", productsPage.GetCategoryName(newProduct.productName));
            Assert.AreEqual("Pasta Buttini s.r.l.", productsPage.GetSupplierName(newProduct.productName));
            Assert.AreEqual("12,0000", productsPage.GetUnitPrice(newProduct.productName));
            Assert.AreEqual("10", productsPage.GetQuantityPerUnit(newProduct.productName));
            Assert.AreEqual("13", productsPage.GetUnitInStock(newProduct.productName));
            Assert.AreEqual("5", productsPage.GetUnitsOnOrder(newProduct.productName));
        }

        [Test]
        public void TestLogout()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            loginPage = ProductService.Login(testUser, driver);
            homePage = homePage.LogoutCheck();
            Assert.AreEqual("Login", loginPage.GetHeadline());
        }
        [TearDown]
        public void cleanup()
        {
            driver.Close();
            driver.Quit();

        }
    }
}