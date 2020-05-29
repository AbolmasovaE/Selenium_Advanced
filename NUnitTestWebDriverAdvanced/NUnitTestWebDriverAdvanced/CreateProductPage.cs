using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestWebDriverAdvanced
{
    class CreateProductPage
    {
        private IWebDriver driver;

        public CreateProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement CreateNewProductButton => driver.FindElement(By.XPath("//a[@class=\"btn btn-default\"]"));


        public IWebElement ProductNameInput => driver.FindElement(By.XPath("//input[contains(@id,\"ProductName\")]"));

        public IWebElement CategoryName => driver.FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]")).FindElement(By.XPath("//select[contains(@id,\"CategoryId\")]/option[@value=\"3\"]"));


        public IWebElement SupplierName => driver.FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]")).FindElement(By.XPath("//select[contains(@id,\"SupplierId\")]/option[@value=\"26\"]"));

        public IWebElement UnitPriceCost => driver.FindElement(By.XPath("//input[contains(@id,\"UnitPrice\")] "));

        public IWebElement QuantityPerUnitNumber => driver.FindElement(By.XPath("//input[contains(@id,\"QuantityPerUnit\")] "));

        public IWebElement UnitsInStockNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsInStock\")] "));

        public IWebElement UnitsOnOrderNumber => driver.FindElement(By.XPath("//input[contains(@id,\"UnitsOnOrder\")] "));

        public IWebElement ReorderLevelNumber => driver.FindElement(By.XPath("//input[contains(@id,\"ReorderLevel\")] "));

        public IWebElement DiscontinuedTrue => driver.FindElement(By.XPath("//input[contains(@id,\"Discontinued\")] "));


        public IWebElement CreateButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));



        public void InputProduct(string nameProduct, string costUnitPrice, string numberQuantityPerUnit, string numberUnitsInStock, string numberUnitsOnOrder, string numberReorderLevel)
        {
            new Actions(driver).Click(CreateNewProductButton).Build().Perform();
            
            ProductNameInput.SendKeys(nameProduct);
            CategoryName.Click();
            SupplierName.Click();
            UnitPriceCost.SendKeys(costUnitPrice);
            QuantityPerUnitNumber.SendKeys(numberQuantityPerUnit);
            UnitsInStockNumber.SendKeys(numberUnitsInStock);
            UnitsOnOrderNumber.SendKeys(numberUnitsOnOrder);
            ReorderLevelNumber.SendKeys(numberReorderLevel);
            DiscontinuedTrue.Click();

            new Actions(driver).Click(CreateButton).Build().Perform();

        }

    }
}
