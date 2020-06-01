using WebDriverFrameworkSF.UI.Page_Object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverFrameworkSF.service.UI
{
    class ProductService
    {
        public static EnteringPage Login(User user, IWebDriver driver)
        {
            EnteringPage loginPage = new EnteringPage(driver);
            EnteringPage enteringPage = loginPage.Login(user);
            return new EnteringPage(driver);
        }

        public static ProductsPage CreateProduct(Products product, IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            ProductsPage productsPage = homePage.AllProductView();
            CreateNewPage createNewPage = productsPage.createButtonClick();
            createNewPage = createNewPage.InputProduct(product);
            productsPage = createNewPage.ClickCreateButton();
            return new ProductsPage(driver);
        }

    }
}

