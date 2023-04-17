using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Ensek.Utils
{
    [Binding]
    public sealed class Hooks
    {

        public static IWebDriver Driver { get; set; }
        private readonly ScenarioContext scenarioContext;
        private readonly FeatureContext featureContext;

        public Hooks(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            this.scenarioContext = scenarioContext;
            this.featureContext = featureContext;
        }

        [BeforeScenario(Order = 1)]
        public static void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine(scenarioContext.ScenarioInfo.Title+" is started");
        }

        [BeforeScenario(Order = 2)]
        public static void SetUp()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddExcludedArgument("enable-automation");
            chromeOptions.AddArguments("chrome.switches", "--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
            Driver = new ChromeDriver(chromeOptions);
            Driver.Navigate().GoToUrl("https://ensekautomationcandidatetest.azurewebsites.net/");
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.Quit();
        }
    }
}