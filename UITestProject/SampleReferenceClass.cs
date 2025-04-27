using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumAutomation.Helper;
using SeleniumExtras.WaitHelpers;

namespace SeleniumAutomation
{
    class SampleReferenceClass
    {
        private readonly IWebDriver driver;

        public SampleReferenceClass(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region WebElements

        private IWebElement usernameTextbox => driver.FindElement(By.Id("user-name"));
        private IWebElement passwordTextbox => driver.FindElement(By.Id("password"));
        private IWebElement loginButton => driver.FindElement(By.Id("login-button"));
        //private IWebElement loginButton => driver.FindElement(By.XPath("(//a[@class = \"et_pb_button et_pb_promo_button\"])[2]"));

        #endregion

        #region Methods

        public void SampleSeleniumMethod()
        {
            //Wait for Page Load
            WaitHelper waitObj = new();
            waitObj.WaitForPageLoad(driver, 5);

            //Selecting from dropdown
            SelectElement element = new SelectElement(loginButton);
            element.SelectByValue("");

            //Selecting all the options in drop down
            if (element.IsMultiple)
            {
                foreach (IWebElement option in element.Options)
                {
                    element.SelectByValue(option.GetAttribute("value"));
                    //or 
                    //option.Click();
                }
            }

            //Action Class Click
            Actions action = new Actions(driver);
            action.Click(usernameTextbox).Perform();

            //Action Class - Move to Ement and Click
            action.MoveToElement(usernameTextbox).Click().Build().Perform();

            //Action Class - Right Click
            action.ContextClick(usernameTextbox).Build().Perform();

            //Action Class - drag and release
            action.ClickAndHold(usernameTextbox).MoveToElement(passwordTextbox).Release().Build().Perform();

            //Fluent Wait
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(4),
                PollingInterval = TimeSpan.FromMilliseconds(400)
            };
            fluentWait.IgnoreExceptionTypes(typeof(ArgumentNullException));
            fluentWait.Until(ExpectedConditions.ElementExists(By.ClassName("app_logo")));

            //Switch to Alert
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            //or
            alert.Dismiss();

            ////Switch to Frame by index
            driver.SwitchTo().Frame(0);

            //Switch to Frame by name
            driver.SwitchTo().Frame("frameName");

            ////Switch to Frame by ID
            driver.SwitchTo().Frame("frameID");

            ////Switch to Parent Frame
            driver.SwitchTo().ParentFrame();

            ////Switch to Default Content
            driver.SwitchTo().DefaultContent();

            ////Switch to Child Frame
            driver.SwitchTo().Frame("ParntFrame");
            driver.SwitchTo().Frame("ChildFrame");

            ////Coming out of child frame
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().DefaultContent();

            ////Switch to Grandchild Frame
            driver.SwitchTo().Frame("ParntFrame");
            driver.SwitchTo().Frame("ChildFrame");
            driver.SwitchTo().Frame("GrandchildFrame");

            //Coming out of Grandchild frame
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().DefaultContent();

            //Switch to other windows
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //Switch to main window
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            //Refresh the page
            driver.Navigate().Refresh();

            //or
            string currentUrl = driver.Url;
            driver.Navigate().GoToUrl(currentUrl);

            //Navigate forward in web
            driver.Navigate().Forward();

            //Navigate back in web
            driver.Navigate().Back();

        }

        //Should be added in helper class
        public void ScrollPage(int x, int y)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);" + $"window.scrollBy({x}, {y});");
        }

        //Should be added in base class or helper class
        public void CloseAllOtherWindows()
        {
            string currentWindowHandle = driver.CurrentWindowHandle;
            foreach (string windowHandle in driver.WindowHandles)
            {
                if (windowHandle != currentWindowHandle)
                {
                    driver.SwitchTo().Window(windowHandle);
                    driver.Close();
                }
            }
            driver.SwitchTo().Window(currentWindowHandle);
        }

        #endregion
    }
}
