using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using BDDCSharpFramework.Utils;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public class Register
    {
        [Given(@"that I click '(.*)'")]
        public void GivenThatIClickALink (string link)
        {
            IWebElement givenLink = Utils.WebDriver.driver.FindElement(By.XPath("//a[contains(text(),'"+link+"')]')"));
           if (givenLink == null)
            {
                Console.WriteLine(link + " link cannot be found.");
            } else
            {
                givenLink.Click();
                Console.WriteLine(link + " link is clicked.");
            }
        }
    }
}
