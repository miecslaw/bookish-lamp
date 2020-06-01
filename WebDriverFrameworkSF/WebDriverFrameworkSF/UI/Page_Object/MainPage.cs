using WebDriverFrameworkSF.UI.Page_Object;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFrameworkSF
{
    class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement LogoutButton => driver.FindElement(By.XPath("//a[@href=\"/Account/Logout\"]"));
        private IWebElement headline => driver.FindElement(By.CssSelector("h2"));
        public EnteringPage ClickLogout()
        {
            new Actions(driver).Click(LogoutButton).Build().Perform();

            return new EnteringPage(driver);
        }
        public string GetHeadline()
        {
            return headline.Text;
        }
    }
}
