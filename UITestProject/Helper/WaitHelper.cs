using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Helper
{
    public class WaitHelper
    {

        public void WaitForPageLoad(IWebDriver driver, int sec)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(sec)).Until(
                d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

    }
}
