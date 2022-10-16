using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace TestingApi.StepDefinitions
{
    [Binding]
    public class ConfirmOrderStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;
        public ConfirmOrderStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\harsh.singh\\Downloads\\chromedriver_win32");
        [Given(@"Open the Website")]
        public void GivenOpenTheWebsite()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:3000/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var Buy_Now_Button = chromeDriver.FindElement(By.XPath("html/body/div/header/div/div[2]/ul/a[1]"));
            chromeDriver.ExecuteScript("arguments[0].click();", Buy_Now_Button);
        }

        [Then(@"Login Page Appears")]
        public void ThenLoginPageAppears()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
        }

        [When(@"I Enter the username and pass")]
        public void WhenIEnterTheUsernameAndPass()
        {
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[1]/div/input")).SendKeys("tom");
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/input")).SendKeys("Tom@123");
        }

        [When(@"click the login button")]
        public void WhenClickTheLoginButton()
        {
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/a")).Click();
        }

        [Then(@"Catalog page Appears")]
        public void ThenCatalogPageAppears()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
        }

        [When(@"I Add a item to Cart")]
        public void WhenIAddAItemToCart()
        {
             chromeDriver.FindElement(By.XPath("html/body/div/div/div/div[1]/div/div[3]/a")).Click();
            //chromeDriver.FindElement(By.Id("Anovate Cream")).Click();
        }

        [When(@"I click on Cart icon")]
        public void WhenIClickOnCartIcon()
        {
            chromeDriver.FindElement(By.XPath("html/body/div/header/div/div[2]/a")).Click();

        }

        [Then(@"Cart Page appears")]
        public void ThenCartPageAppears()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
        }

        [When(@"I click on Checkout button")]
        public void WhenIClickOnCheckoutButton()
        {
            chromeDriver.FindElement(By.XPath("html/body/div/div/div[2]/div[2]/a")).Click();
        }

        [Then(@"Checkout page appears")]
        public void ThenCheckoutPageAppears()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
        }
    }
}
