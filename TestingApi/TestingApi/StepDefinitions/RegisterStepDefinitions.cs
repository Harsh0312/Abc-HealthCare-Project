using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace TestingApi.StepDefinitions
{
    [Binding]
    public class RegisterStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;
        public RegisterStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\harsh.singh\\Downloads\\chromedriver_win32");
        [Given(@"I navigates to website")]
        public void GivenINavigatesToWebsite()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:3000/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }

        [Then(@"I clicks on Register button")]
        public void ThenIClicksOnRegisterButton()
        {
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(15000));
            var Register_button = chromeDriver.FindElement(By.XPath("html/body/div/header/div/div[2]/ul/a[2]"));
            chromeDriver.ExecuteScript("arguments[0].click();", Register_button);
        }

        [Then(@"I enters Username Email and Password")]
        public void ThenIEntersUsernameEmailAndPassword()
        {
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[1]/div/input")).SendKeys("Manish");
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[2]/div/input")).SendKeys("Manish@123.com");
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/div[3]/div/input")).SendKeys("Manish@123");



        }
        [Then(@"I clicks on Register buttons")]
        public void ThenIClicksOnRegisterButtons()
        {
            chromeDriver.FindElement(By.XPath("/html/body/div/div/div/form/button")).Click();

        }

    }
}
