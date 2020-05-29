using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestWebDriverAdvanced
{
    class HomePage
    {
        public IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement AllProductsButton => driver.FindElement(By.XPath("//div/a[@href=\"/Product\"]"));

        public IWebElement LogoutButton => driver.FindElement(By.XPath("//a[@href=\"/Account/Logout\"]"));

        public IWebElement textLabel => driver.FindElement(By.XPath("//h2"));

        public CreateProductPage AllProductView()
        {
            AllProductsButton.Click();
            return new CreateProductPage(driver);
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

