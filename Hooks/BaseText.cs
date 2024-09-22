using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace NewBpbonline.Hooks
{
    [Binding]
    public  class BaseText
    {
        public static  IWebDriver driver;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           



        }
        public void goToUrl()
        {
            string url = "https://bpbonline.com/";
            driver.Navigate().GoToUrl(url);
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
           
        }
    }
}