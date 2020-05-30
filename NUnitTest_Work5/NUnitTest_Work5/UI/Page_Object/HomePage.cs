using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Work5.UI.Page_Object
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement AllProductsButton => driver.FindElement(By.XPath("//div/a[@href=\"/Product\"]"));

        private IWebElement LogoutButton => driver.FindElement(By.XPath("//a[@href=\"/Account/Logout\"]"));

        private IWebElement textLabel => driver.FindElement(By.XPath("//h2"));

        public AllProductsPage AllProductView()
        {
            AllProductsButton.Click();
            return new AllProductsPage(driver);
        }

        public StartPage LogoutCheck()
        {
            new Actions(driver).Click(LogoutButton).Build().Perform();

            return new StartPage(driver);
        }

        public string GetText()
        {
            return textLabel.Text;
        }
    }
}

