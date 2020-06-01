using NUnit.Framework;
using WebDriverFrameworkSF.UI.Page_Object;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace WebDriverFrameworkSF.step_definition
{
    [Binding]
    public sealed class LoginStep
    {
        private IWebDriver driver;

        [Given(@"I open the url ""(.*)""")]
        public void GivenIOpenTheURL(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;

        }

        [When(@"I enter ""(.*)"" in the field Name")]
        public void WhenIEnterUserInTheFieldName(string name)
        {
            new EnteringPage(driver).GetName(name);
        }

        [When(@"I enter ""(.*)"" in the field Password")]
        public void WhenIEnterUserInTheFieldPassword(string password)
        {
            new EnteringPage(driver).GetPassword(password);
        }

        [When(@"I click on Send-button")]
        public void WhenIClickOnTheButtonSend()
        {
            new EnteringPage(driver).SendButtonClick();
        }

        [Then(@"I see headline ""(.*)"" on page")]
        public void ThenIseeheadlineonpage (string nameProduct)
        {
            MainPage mainPage = new MainPage(driver);
            Assert.AreEqual("Home page", mainPage.GetHeadline());
        }
        
    }
}
