using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Utils.WebDriver.driver.Manage().Cookies.DeleteAllCookies();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Utils.WebDriver.driver.Quit();
        }
    }
}
