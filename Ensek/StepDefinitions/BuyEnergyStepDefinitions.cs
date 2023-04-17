using Ensek.Pages;
using System;
using TechTalk.SpecFlow;

namespace Ensek.StepDefinitions
{
    [Binding]
    public class BuyEnergyStepDefinitions
    {
        BuyEnergyPage buyEnergyPage = new BuyEnergyPage();

        [Given(@"navigate to buy energy page")]
        public void GivenNavigateToBuyEnergyPage()
        {
            buyEnergyPage.ClickBuyEnergyOption();
            buyEnergyPage.ClickResetButton();
        }

        [When(@"enter '([^']*)' units in unit field '([^']*)'")]
        public void WhenEnterUnitsInUnitField(string energyType, string unit)
        {
            buyEnergyPage.EnterUnitValue(energyType, unit);
        }


        [Then(@"click buy button for '([^']*)'")]
        public void ThenClickBuyButtonFor(string energyType)
        {
            buyEnergyPage.ClickBuyButton(energyType);
        }


        [Then(@"verify purchase message")]
        public void ThenVerifyPurchaseMessage()
        {
            buyEnergyPage.VerifyPurchaseMessage();
        }
    }
}
