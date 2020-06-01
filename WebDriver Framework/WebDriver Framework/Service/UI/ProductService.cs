using OpenQA.Selenium;
using WebDriverFramework.Business_object;

namespace WebDriverFramework.ui
{
    class ProductService
    {
        public static ProductsPage CreateProduct(Products product, IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            ProductsPage productsPage = homePage.AllProductView();
            CreateNewPage createNewPage = productsPage.createNewButtonClick();
            productsPage = createNewPage.InputProduct(product);
            return new ProductsPage(driver);
        }

        public static LoginPage Login(User testUser, IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage = loginPage.LoginInput(testUser);
            return new LoginPage(driver);
        }

    }
}

