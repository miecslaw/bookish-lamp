using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebDriver_Basic
{
    class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement logoutButton =>driver.FindElement(By.XPath("//ul//a[@href=\"/Account/Logout\"]"));
        public void Logout()
        {
            new Actions(driver).Click(logoutButton).Build().Perform();
        }
    }
}
