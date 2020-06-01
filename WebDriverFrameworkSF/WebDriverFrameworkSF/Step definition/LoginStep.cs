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

        [When(@"I click on the button Send")]
        public void WhenIClickOnTheButtonSend()
        {
            new EnteringPage(driver).SendButtonClick();
        }

        [When(@"I click on the button AllProducts")]
        public void WhenIClickOnTheAllProductButton()
        {
            new HomePage(driver).AllProductView();
        }

        [When(@"I click on the button CreateNew")]
        public void WhenIClickOnTheCreateNewButton()
        {
            new ProductsPage(driver).createButtonClick();
        }

        [When(@"I enter the product info in the field: NameProduct ""(.*)"", UnitPrice ""(.*)"", QuantityPerUnit ""(.*)"", UnitInStock ""(.*)"", UnitsOnOrder ""(.*)""")]
        public void WhenIEnterTheProductInfoInTheField(string nameProduct, string costUnitPrice, string numberQuantityPerUnit, string numberUnitsInStock, string unitsOnOrder)
        {
            CreateNewPage createProductPage = new CreateNewPage(driver);
            createProductPage = createProductPage.InputProduct(new Products(nameProduct, costUnitPrice, numberQuantityPerUnit, numberUnitsInStock, unitsOnOrder));


        }

        [When(@"I select category ""(.*)"" and supplier ""(.*)"" in the fields")]
        public void WhenISelectTCategoryAndSupplierInTheFields(int category, int supplier)
        {
            new CreateNewPage(driver).CategorySupplierClick(category, supplier);
        }

        [When(@"I click on the button CreateProduct")]
        public void WhenIClickOnTheButtonCreateProduct()
        {
            new CreateNewPage(driver).ClickCreateButton();
        }
        [Then(@"I see product ""(.*)"" in the table All Product")]
        public void ThenIseeTheCreatedProductInTheTable(string nameProduct)
        {
            ProductsPage productsPage = new ProductsPage(driver);

            Assert.AreEqual("TestProduct", productsPage.GetProductName(nameProduct));

        }

    }
}
