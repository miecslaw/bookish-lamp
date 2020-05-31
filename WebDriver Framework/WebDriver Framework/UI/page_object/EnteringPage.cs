using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using WebDriver_Basic.Business_object;

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
        public EnteringPage LoginTest (User testNameAndPassword)
        {
            new Actions(driver).Click(nameInput).SendKeys(testNameAndPassword.Name).Build().Perform();
            new Actions(driver).Click(passwordInput).SendKeys(testNameAndPassword.Password).Build().Perform();
            return this;
        }
        public string GetTextElementValue()
        {
            return textElement.Text;
        }
        public EnteringPage ClickButton()
        {
            new Actions(driver).Click(loginButton).Build().Perform();
            return this;
        }

    }
}
