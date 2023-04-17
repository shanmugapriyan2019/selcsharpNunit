using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensek.Pages
{
    public class BuyEnergyPage : BasePage
    {

        public void ClickBuyEnergyOption()
        {
            Click(By.CssSelector("a[href*=\"Energy\"][href*=\"Buy\"]"), "Buy energy button", 10);
        }

        public void ClickResetButton()
        {
            Click(By.CssSelector("input[name='Reset']"),"Reset button",10);
        }
        public void ClickBuyButton(string energyType)
        {
            string by = energyType.Equals("Gas") ? "tr:nth-child(1) input[name='Buy']" : "tr:nth-child(4) input[name='Buy']";
            Click(By.CssSelector(by), "Buy button for "+energyType, 10);
        }

        public void EnterUnitValue(string energyType, string unit)
        {
            string by = energyType.Equals("Gas") ? "tr:nth-child(1) input[id='energyType_AmountPurchased']" : "tr:nth-child(4) input[id='energyType_AmountPurchased']";
            Enter(By.CssSelector(by),unit,energyType+" unit field",10);

        }
        public void VerifyPurchaseMessage()
        {
            if (FindElementVisibility(By.XPath("//div[@class='well' and contains(text(),'Thank you for your purchase')]"), 10) != null)
            {
                Console.WriteLine("Thank you for your purchase message is displayed");
            }
            else
            {
                Console.WriteLine("Thank you for your purchase message is not displayed");
            }
        }
    }
}
