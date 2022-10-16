using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace TestingApi.StepDefinitions
{
    [Binding]
    public class OpeningtheAbcHealthCareAppStepDefinitions
    {
        private String searchKeyword;

        private ChromeDriver chromeDriver;

        public OpeningtheAbcHealthCareAppStepDefinitions() => chromeDriver = new ChromeDriver("C:\\Users\\harsh.singh\\Downloads\\chromedriver_win32");
        [Given(@"Navigate to the Health care")]
        public void GivenNavigateToTheHealthCare()
        {
            chromeDriver.Navigate().GoToUrl("http://localhost:3000/");
            WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromMilliseconds(9500));
        }
    }
}
