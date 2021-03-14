using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDCSharpFramework.Step_Definitions
{
    [Binding]
    public sealed class Hooks
    {
        [AfterTestRun]
        public static void AfterTestRun()
        {
            Utils.WebDriver.driver.Quit();
        }
    }
}
