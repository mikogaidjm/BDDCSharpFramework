using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using BDDCSharpFramework.Utils;
using System;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public class InitializeTest
    {

        [Given(@"that '(.*)' is the browser")]
        public void GivenThatSomethingIsTheBrowser(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    Utils.WebDriver.driver = new ChromeDriver();
                    break;
                case "Firefox":
                    Utils.WebDriver.driver = new FirefoxDriver();
                    break;
                case "Edge":
                    Utils.WebDriver.driver = new EdgeDriver();
                    break;
            }
            Console.WriteLine("I am using " + browser + ".");
        }

        [When(@"I access this link: '(.*)'")]
        public void WhenIAccessThisLink(string link)
        {
            Utils.WebDriver.driver.Url = link;
            Console.WriteLine("I am accessing " + link + ".");
        }

        [Then(@"the page should be displayed")]
        public void ThenThePageShouldBeDisplayed()
        {
            Console.WriteLine("The page is displayed.");
        }
    }
}
