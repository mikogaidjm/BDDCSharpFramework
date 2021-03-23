using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void BeforerTestRun()
        {
            Utils.WebDriver.driver = new ChromeDriver();
            Console.WriteLine("I am using Chrome.");
            // Utils.WebDriver.driver = new FirefoxDriver();
            // Console.WriteLine("I am using Firefox.");
            // Utils.WebDriver.driver = new EdgeDriver();
            // Console.WriteLine("I am using Edge.");
            Utils.WebDriver.driver.Url = "https://parabank.parasoft.com/parabank/index.htm";
            Console.WriteLine("I am accessing " + Utils.WebDriver.driver.Url + ".");
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Utils.WebDriver.driver.Quit();
        }
    }
}
