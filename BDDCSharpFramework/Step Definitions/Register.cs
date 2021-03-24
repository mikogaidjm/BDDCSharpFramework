using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using BDDCSharpFramework.Utils;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public class Register
    {
        private Credentials registerInfo = new Credentials();

        [Given(@"someone sets the following fields")]
        public void GivenSomeoneSetsTheFollowingFields(Table given)
        {
            IEnumerable<RegisterClass> fields = given.CreateSet<RegisterClass>();

            foreach (RegisterClass element in fields)
            {
                IWebElement givenElement = Utils.WebDriver.driver.FindElement(By.Id(element.FieldName));
                if (givenElement == null)
                {
                    Console.WriteLine(element.FieldName + " field cannot be found.");
                }
                else
                {
                    givenElement.SendKeys(element.FieldValue);
                    if (element.FieldName.Contains("username"))
                    {
                        registerInfo.Username = element.FieldValue;
                    } else if(element.FieldName.Contains("password"))
                    {
                        registerInfo.Password = element.FieldValue;
                    }
                    Console.WriteLine(element.FieldName + " field is set to " + element.FieldValue + ".");
                }
            }         
        }

        [Then(@"the welcome page should be displayed")]
        public void ThenTheWelcomePageShouldBeDisplayed()
        {
            IWebElement givenElement = Utils.WebDriver.driver.FindElement(By.XPath("//h1[contains(text(),'Welcome " + registerInfo.Username + "')]"));
            if (givenElement == null)
            {
                Console.WriteLine("The welcome page is not displayed.");
            }
            else
            {
                Console.WriteLine("The welcome page is displayed.");
            }
        }
    }
}
