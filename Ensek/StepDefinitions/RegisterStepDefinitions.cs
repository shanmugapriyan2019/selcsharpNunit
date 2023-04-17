using Ensek.Pages;
using System;
using TechTalk.SpecFlow;

namespace Ensek.StepDefinitions
{
    [Binding]
    public class RegisterStepDefinitions
    {
        RegisterPage registerPage = new RegisterPage();
        [Given(@"navigate to Register page")]
        public void GivenNavigateToRegisterPage()
        {
            registerPage.ClickRegisterLink();
        }

        [When(@"enter email address '([^']*)'")]
        public void WhenEnterEmailAddress(string email)
        {
            registerPage.EnterEmailAddress(email);
        }

        [Then(@"enter password '([^']*)'")]
        public void ThenEnterPassword(string password)
        {
            registerPage.EnterPassword(password);
        }

        [Then(@"enter confirm password '([^']*)'")]
        public void ThenEnterConfirmPassword(string confirmPassword)
        {
            registerPage.EnterConfirmPassword(confirmPassword);
        }

        [Then(@"click register button")]
        public void ThenClickRegisterButton()
        {
            registerPage.ClickRegisterButton();
        }

        [Then(@"verify error message")]
        public void ThenVerifyErrorMessage()
        {
            registerPage.VerifyErrorMessage();
        }

    }
}
