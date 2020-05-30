using NUnitTest_Work5.UI.Page_Object;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace NUnitTest_Work5.Service.UI
{
    class ProductService
    {
        public static AllProductsPage CreateProduct(Products product, IWebDriver driver)
        {
            HomePage homePage = new HomePage(driver);
            AllProductsPage allProductsPage = homePage.AllProductView();
            CreateProductPage createProductPage = allProductsPage.createButtonClick();
            allProductsPage = createProductPage.InputProduct(product);
            return new AllProductsPage(driver);
        }

    }
}
