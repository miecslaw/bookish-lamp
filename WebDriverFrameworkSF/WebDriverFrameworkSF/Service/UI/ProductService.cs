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

    }
}

