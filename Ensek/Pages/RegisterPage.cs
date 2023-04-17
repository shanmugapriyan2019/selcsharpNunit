using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensek.Pages
{
    public class RegisterPage : BasePage
    {
        public void ClickRegisterLink()
        {
            Click(By.CssSelector("a#registerLink"), "Registration option", 10);
        }

        public void EnterEmailAddress(string email)
        {
            Enter(By.CssSelector("input#Email"), email, "Email address", 10);
        }
        public void EnterPassword(string password)
        {
            Enter(By.CssSelector("input#Password"), password, "Password address", 10);
        }
        public void EnterConfirmPassword(string confirmPassword)
        {
            Enter(By.CssSelector("input#ConfirmPassword"), confirmPassword, "Confirm Password address", 10);
        }

        public void ClickRegisterButton()
        {
            Click(By.CssSelector("input[value='Register']"),"Register button",10);
        }

        public void VerifyErrorMessage()
        {
            if (FindElementVisibility(By.CssSelector("div[class *='validation-summary-errors']"),10) != null)
            {
                Console.WriteLine("Error message is displayed");
            }
            else 
            {
                Console.WriteLine("Error message is not displayed");
            }
        }
    }
}
