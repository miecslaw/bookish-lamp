using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Work5
{
    class EnteringPage
    {
        private IWebDriver driver;

        public EnteringPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement LoginNameInput => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@id=\"Password\"]"));

        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));

        private IWebElement startPageText => driver.FindElement(By.XPath("//h2"));

        public EnteringPage NameLoginInput(string loginNameInput)
        {
            LoginNameInput.SendKeys(loginNameInput);
            return this;
        }

        public EnteringPage LoginPaswordInput(string passwordInput)
        {
            PasswordInput.SendKeys(passwordInput);
            return this;
        }

        public MainPage SendButtonClick()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            LoginButton.Click();
            return new MainPage(driver);
        }


        public string GetStartPageText()
        {
            return startPageText.Text;
        }

    }
}