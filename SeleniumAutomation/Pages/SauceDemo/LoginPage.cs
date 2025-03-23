using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumAutomation.Config;
using SeleniumAutomation.Helper;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.Pages.SauceDemo
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
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

        public void LoginSite(string userName, string password)
        {
            usernameTextbox.SendKeys(userName);
            passwordTextbox.SendKeys(password);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("arguments[0].scrollIntoView();", loginButton);
            loginButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("app_logo")));
            Task.Delay(TimeSpan.FromSeconds(6)).Wait();
            //WaitHelper waitObj = new();
            //waitObj.WaitForPageLoad(driver, 5);

            SelectElement element = new SelectElement(loginButton);
            element.SelectByValue("");

            Actions action = new Actions(driver);
            action.ContextClick(usernameTextbox).Build().Perform();

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(4),
                PollingInterval = TimeSpan.FromMilliseconds(400)
            };
            fluentWait.IgnoreExceptionTypes(typeof(ArgumentNullException));
            fluentWait.Until(ExpectedConditions.ElementExists(By.ClassName("app_logo")));


            Assert.That(driver.Url.Contains("inventory"));
            
        }

        #endregion
    }
}
