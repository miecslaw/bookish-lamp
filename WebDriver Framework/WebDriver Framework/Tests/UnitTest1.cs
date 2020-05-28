using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver_Basic;
using WebDriver_Basic.Business_object;

namespace WebDriver_Advanced
{
    public class Tests
    {
        private IWebDriver driver;
        //private WebDriverWait wait;
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
        private User testNameAnPassword = new User("user",
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
            Login();
        }
        [Test]
        public void AddProduct()
        {
            addingPage = new AddingPage(driver);
            Login();
            addingPage.Adding(testProduct);
            Assert.AreNotEqual("Product editing", addingPage.GetTextElementValue());
            Assert.AreNotEqual(addingPage.CheckingBefore(), addingPage.CheckingAfter());
        }
        [Test]
        public void LogoutTest()
        {
            mainPage = new MainPage(driver);
            Login();
            mainPage.Logout();
            Assert.AreEqual("Login",mainPage.GetTextElementValue());
        }
        public void Login()
        {
            enteringPage = new EnteringPage(driver);
            enteringPage.LoginTest(testNameAnPassword);
            Assert.AreEqual("Home page", enteringPage.GetTextElementValue());
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}