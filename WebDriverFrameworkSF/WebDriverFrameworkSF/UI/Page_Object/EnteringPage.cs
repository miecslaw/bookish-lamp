using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFrameworkSF.UI.Page_Object
{
    class EnteringPage
    {
        private IWebDriver driver;

        public EnteringPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private string TestLogin;
        private IWebElement nameInput => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement passwordInput => driver.FindElement(By.XPath("//input[@id=\"Password\"]"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));
        private IWebElement headline => driver.FindElement(By.XPath("//h2"));

        public EnteringPage Login(User login)
        {
            nameInput.SendKeys(login.nameInput);
            passwordInput.SendKeys(login.passwordInput);
            loginButton.Click();
            return this;
        }
        public string GetHeadline()
        {
            return headline.Text;
        }
        public EnteringPage SendButtonClick()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            loginButton.Click();
            return new EnteringPage(driver);
        }
        public EnteringPage GetName(string currentNameInput)
        {
            nameInput.SendKeys(currentNameInput);
            return this;
        }
        public EnteringPage GetPassword(string currentPasswordInput)
        {
            passwordInput.SendKeys(currentPasswordInput);
            return this;


        }
    }
}