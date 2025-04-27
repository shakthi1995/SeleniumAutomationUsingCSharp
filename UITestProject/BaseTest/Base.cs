using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomation.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation.BaseTest
{
    public class Base
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();

            // Disable pop-ups
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--disable-notifications");
            //options.AddAdditionalOption("unexpectedAlertBehaviour", "accept", true);

            // Auto-accept alerts (useful for handling JavaScript alerts)
            options.AddUserProfilePreference("profile.default_content_setting_values.popups", 0);
            options.AddUserProfilePreference("profile.default_content_setting_values.automatic_downloads", 1);
            options.AddUserProfilePreference("profile.password_manager_leak_detection", false);
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(UserDetails.GetUrl);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void TearDown() 
        {
            driver.Dispose();
        }

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
    }
}
