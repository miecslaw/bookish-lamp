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
        private IWebElement textElement => driver.FindElement(By.CssSelector("h2"));
        public void Logout()
        {
            new Actions(driver).Click(logoutButton).Build().Perform();
        }
        public string GetTextElementValue()
        {
            return textElement.Text;
        }
    }
}
