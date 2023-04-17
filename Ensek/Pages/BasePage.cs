using Ensek.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensek.Pages
{
    public class BasePage
    {
        readonly IWebDriver driver;

        public BasePage() {
            this.driver = Hooks.Driver;
        }

        public void NavigateURL(String url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public IWebElement FindElementClickable(By locator, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            try
            {

                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            }
            catch (Exception e)
            {
                return null;

            }
        }
        public IWebElement FindElementVisibility(By locator, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            try
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return driver.FindElement(locator);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public IWebElement FindElementPresence(By locator, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            try
            {

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
                return driver.FindElement(locator);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public IList<IWebElement> FindMultipleElements(By locator, int time)
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));
                return driver.FindElements(locator);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void Click(By locator, string name, int timeInSec)
        {
            try
            {
                IWebElement webElement = FindElementClickable(locator, timeInSec);
                if (webElement != null)
                {
                    webElement.Click();
                }
                else
                {
                    Assert.Fail(name + "is not clicked ");
                }
            }
            catch (Exception e)
            {
                Assert.Fail(name + "is not clicked " + e);
            }
        }
        public void Enter(By locator, string value, string name, int timeInSec)
        {
            try
            {
                IWebElement webElement = FindElementClickable(locator, timeInSec);
                if (webElement != null)
                {
                    webElement.Click();
                    webElement.Clear();
                    webElement.SendKeys(value);
                }
                else
                {
                    Assert.Fail(name + "is not visible ");
                }
            }
            catch (Exception e)
            {
                Assert.Fail(name + "is not visible " + e);
                Console.WriteLine(e);
            }
        }
    }
}
