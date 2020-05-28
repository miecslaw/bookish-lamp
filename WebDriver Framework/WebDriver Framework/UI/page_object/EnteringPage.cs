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
        public void LoginTest (User testNameAnPassword)
        {
            new Actions(driver).Click(nameInput).SendKeys(testNameAnPassword.Name).Build().Perform();
            new Actions(driver).Click(passwordInput).SendKeys(testNameAnPassword.Password).Build().Perform();
            new Actions(driver).Click(loginButton).Build().Perform();
        }
        public string GetTextElementValue()
        {
            return textElement.Text;
        }

    }
}
