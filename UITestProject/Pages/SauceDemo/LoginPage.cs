using NuGet.Frameworks;
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
        //private By userName = By.Id("user-name");
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

            //Scroll to the element - not necessary for this scenario
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", loginButton);


            loginButton.Click();

            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("app_logo")));

            //Delaying the task for 6 seconds
            Task.Delay(TimeSpan.FromSeconds(6)).Wait();

            Assert.That(driver.Url.Contains("inventory"));

        }

        #endregion
    }
}
