using OpenQA.Selenium;
using WebDriverFramework.Business_object;

namespace WebDriverFramework
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement NameInput => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@id=\"Password\"]"));
        private IWebElement SendButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));
        private IWebElement Headline => driver.FindElement(By.XPath("//h2"));
        public LoginPage LoginInput(User testUser)
        {
            NameInput.SendKeys(testUser.Name);
            PasswordInput.SendKeys(testUser.Password);
            SendButton.Click();
            return new LoginPage(driver);
        }
        public string GetHeadline()
        {
            return Headline.Text;
        }
    }
}