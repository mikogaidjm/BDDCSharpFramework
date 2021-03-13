using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDCSharpFramework.Utils
{
    public class WebDriver
    {
        public static IWebDriver driver { get; set; }

        public static IJavaScriptExecutor Scripts()
        {
            return (IJavaScriptExecutor)driver;
        }
    }
}
