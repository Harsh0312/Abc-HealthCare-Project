using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TestingApi.StepDefinitions
{
    [Binding]
    public class LogintoAppStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;
        public LogintoAppStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\harsh.singh\\Downloads\\chromedriver_win32");
        [Given(@"Navigate to Abc healthCare")]
        public void GivenNavigateToAbcHealthCare()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:3000/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));

        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var Buy_Now_Button = chromeDriver.FindElement(By.XPath("html/body/div/header/div/div[2]/ul/a[1]"));
            chromeDriver.ExecuteScript("arguments[0].click();", Buy_Now_Button);
        }

        [Then(@"Login page Appear")]
        public void ThenLoginPageAppear()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));

        }

        [When(@"enter username and password")]
        public void WhenEnterUsernameAndPassword(Table table)
        {
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[1]/div/input")).SendKeys("tom");
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/input")).SendKeys("Tom@123");

        }

        [When(@"Click SignIn")]
        public void WhenClickSignIn()
        {
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/a")).Click();

        }

        [Then(@"See Catalog Page")]
        public void ThenSeeCatalogPage()
        {
            throw new PendingStepException();
        }
    }
}
