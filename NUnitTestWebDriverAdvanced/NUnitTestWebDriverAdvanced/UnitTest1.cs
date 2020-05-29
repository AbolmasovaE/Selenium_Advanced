using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;



namespace NUnitTestWebDriverAdvanced
{
    public class Tests
    {
        private IWebDriver driver;
        private CreateProductPage createProductPage;
        private StartPage startPage;
        private HomePage homePage;
        private AllProductsPage checkNewProduct;
        private const string nameProduct = "Ketchup";
        private const string costUnitPrice = "123";
        private const string numberQuantityPerUnit = "3-5";
        private const string numberUnitsInStock = "7";
        private const string numberUnitsOnOrder = "2";
        private const string numberReorderLevel = "10";
        private const string loginName = "user";
        private const string password = "user";


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [SetUp]
        public void Start()
        {
            startPage = new StartPage(driver);
            homePage = startPage.LoginInput(loginName, password);

        }
        [Test]
        public void TestLogin()
        {

            Assert.AreEqual("Home page", homePage.GetText());

        }

        [Test]
        public void TestCreateProduct()
        {
            createProductPage = homePage.AllProductView();

            
            createProductPage.InputProduct(nameProduct, costUnitPrice, numberQuantityPerUnit, numberUnitsInStock, numberUnitsOnOrder, numberReorderLevel);

            
            checkNewProduct = new AllProductsPage(driver);

            Assert.AreEqual("Ketchup", checkNewProduct.GetNameProductText(nameProduct));
            Assert.AreEqual("Condiments", checkNewProduct.GetCategoryText(nameProduct));
            Assert.AreEqual("Exotic Liquids", checkNewProduct.GetSupplierText(nameProduct));
            Assert.AreEqual("3-5", checkNewProduct.GetQuantityPerUnitText(nameProduct));
            Assert.AreEqual("123,0000", checkNewProduct.GetUnitPriceText(nameProduct));
            Assert.AreEqual("7", checkNewProduct.GetUnitInStockText(nameProduct));
            Assert.AreEqual("2", checkNewProduct.GetUnitsOnOrderText(nameProduct));
            Assert.AreEqual("10", checkNewProduct.GetReorderLevelText(nameProduct));
            Assert.AreEqual("True", checkNewProduct.GetDiscontinuedText(nameProduct));
        }

        [Test]
        public void testlogout()
        {

            startPage = homePage.LogoutCheck();
            Assert.AreEqual("Login", startPage.GetStartPageText());
        }

        [TearDown]
        public void cleanup()
        {
            driver.Close();
            driver.Quit();

        }
    }
}