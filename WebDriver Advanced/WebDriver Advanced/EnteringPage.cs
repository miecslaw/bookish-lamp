using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace WebDriver_Basic
{
    class EnteringPage
    {
        private IWebDriver driver;

        public EnteringPage(IWebDriver driver)
        { 
            this.driver = driver;
        }
        private IWebElement textElement => driver.FindElement(By.CssSelector("h2"));
        private IWebElement nameInput => driver.FindElement(By.XPath("//input[@Name]"));
        private IWebElement passwordInput =>driver.FindElement(By.CssSelector("input#Password"));
        private IWebElement loginButton => driver.FindElement(By.CssSelector("input.btn.btn-default"));
        public void Login ()
        {
            new Actions(driver).Click(nameInput).SendKeys("user").Build().Perform();
            new Actions(driver).Click(passwordInput).SendKeys("user").Build().Perform();
            new Actions(driver).Click(loginButton).Build().Perform();
        }
        public string GetTextElementValue()
        {
            return textElement.Text;
        }

    }
}
