using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestWebDriverAdvanced
{
    class StartPage
    {
        private IWebDriver driver;

        public StartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement LoginNameInput => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement PasswordInput => driver.FindElement(By.XPath("//input[@id=\"Password\"]"));

        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@type=\"submit\"]"));

        private IWebElement startPageText => driver.FindElement(By.XPath("//h2"));

        public HomePage LoginInput(string loginNameInput, string passwordInput)
        {
            LoginNameInput.SendKeys(loginNameInput);
            PasswordInput.SendKeys(passwordInput);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            LoginButton.Click();
            return new HomePage(driver);

        }

        public string GetStartPageText()
        {
            return startPageText.Text;
        }

    }
}

