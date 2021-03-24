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
        [Given(@"I log in with (.*) and (.*)")]
        public void GivenILogInWithUsernameAndPassword(string username, string password)
        {
            IWebElement userName = Utils.WebDriver.driver.FindElement(By.XPath("//input[contains(@name, 'username')]"));
            IWebElement passWord = Utils.WebDriver.driver.FindElement(By.XPath("//input[contains(@name, 'password')]"));
            if (userName == null || passWord == null)
            {
                Console.WriteLine("Log-in element not found.");
            }
            else
            {
                userName.SendKeys(username);
                passWord.SendKeys(password);
                Console.WriteLine(username + " and " + password + " inputted.");
            }
        }

    }
}
