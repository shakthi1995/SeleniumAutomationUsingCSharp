using SeleniumAutomation.BaseTest;
using SeleniumAutomation.Config;
using SeleniumAutomation.Pages.SauceDemo;

namespace SeleniumAutomation.Tests
{
    [TestFixture]
    public class UITests : Base
    {
        [Test]
        public void LogInToSauceDemoWebsite()
        {
            LoginPage login = new LoginPage(driver);
            login.LoginSite(UserDetails.GetUserName, UserDetails.GetPassword);

        }
       
    }
}