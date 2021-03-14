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
        [Given(@"that someone clicks the (.*) link")]
        public void GivenThatSomeoneClicksALink (string link)
        {
            IWebElement givenLink = Utils.WebDriver.driver.FindElement(By.XPath("//a[contains(text(),'"+link+"')]"));
           if (givenLink == null)
            {
                Console.WriteLine(link + " link cannot be found.");
            } else
            {
                givenLink.Click();
                Console.WriteLine(link + " link is clicked.");
            }
        }

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
                    Console.WriteLine(element.FieldName + " field is set to " + element.FieldValue + ".");
                }
            }         
        }

        [When(@"the (.*) button is clicked")]
        public void WhenTheButtonIsClicked(string button)
        {
            IWebElement givenElement = Utils.WebDriver.driver.FindElement(By.XPath("//input[contains(@value, '"+ button +"')]"));
            if (givenElement == null)
            {
                Console.WriteLine(button + " button cannot be found.");
            }
            else
            {
                givenElement.Click();
                Console.WriteLine(button + " button is clicked.");
            }
        }

        [Then(@"the welcome page should be displayed")]
        public void ThenTheWelcomePageShouldBeDisplayed()
        {
            Console.WriteLine("The welcome page is displayed.");
        }
    }
}
