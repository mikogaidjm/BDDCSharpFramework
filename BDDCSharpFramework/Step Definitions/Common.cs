using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using BDDCSharpFramework.Utils;
using OpenQA.Selenium.Support.UI;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public class Common
    {
        [Given(@"that someone clicks the (.*) link")]
        public void GivenThatSomeoneClicksALink(string link)
        {
            WebDriverWait wait = new WebDriverWait(Utils.WebDriver.driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(),'" + link + "')]")));
            IWebElement givenLink = Utils.WebDriver.driver.FindElement(By.XPath("//a[contains(text(),'" + link + "')]"));
            if (givenLink == null)
            {
                Console.WriteLine(link + " link cannot be found.");
            }
            else
            {
                givenLink.Click();
                Console.WriteLine(link + " link is clicked.");
            }
        }

        [When(@"the (.*) button is clicked")]
        public void WhenTheButtonIsClicked(string button)
        {
            IWebElement givenElement = Utils.WebDriver.driver.FindElement(By.XPath("//input[contains(@value, '" + button + "')]"));
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

        [When(@"the (.*) table is displayed")]
        public void WhenTheTableIsDisplayed(string table)
        {
            IWebElement givenElement = Utils.WebDriver.driver.FindElement(By.XPath("//h1[contains(text(),'" + table + "')]/../table"));
            if (givenElement == null)
            {
                Console.WriteLine(table + " table cannot be found.");
            }
            else
            {
                Console.WriteLine(table + " table is clicked.");
            }
        }
    }
}
