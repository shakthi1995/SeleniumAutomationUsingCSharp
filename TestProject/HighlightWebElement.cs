using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class HighlightWebElement
    {
        public void HighlightWebElementInRed(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            for(int i = 0; i < 5; i++)
            {
                js.ExecuteScript("arguments[0].style.border='3px solid red'", element);
                Thread.Sleep(300);
                js.ExecuteScript("arguments[0].style.border=''", element);
                Thread.Sleep(300);
            }
            
        }
    }
}
