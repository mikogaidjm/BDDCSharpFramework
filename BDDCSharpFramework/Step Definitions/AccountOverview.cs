using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using BDDCSharpFramework.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public class AccountOverview
    {
        [Then(@"the (.*) row value should be (.*)")]
        public void ThenTheTableRowShouldBeSomething(string row, string value)
        {
            WebDriverWait wait = new WebDriverWait(Utils.WebDriver.driver, new TimeSpan(0, 0, 10));
            IWebElement givenElement = Utils.WebDriver.driver.FindElement(By.XPath("//tr/td[@id='"+ row +"']"));
            wait.Until(ExpectedConditions.TextToBePresentInElement(givenElement, value));
            if (givenElement == null)
            {
                Console.WriteLine(row + " cannot be found.");
            }
            else
            {
                Assert.IsTrue(givenElement.Text.Equals(value));
                Console.WriteLine("The value of " + row + " row is equal to " + value + ".");                
            }
        }
    }
}
