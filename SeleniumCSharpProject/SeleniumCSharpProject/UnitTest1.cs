using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCSharpProject
{
    public class Tests:DriverHelper
    {
        [SetUp]
        public static void Setup()
        {
            Driver = new ChromeDriver();
            Console.WriteLine("Test1");
        }

        [Test]
        public static void Test1()
        {
            Driver.Navigate().GoToUrl("https://www.letterboxd.com/");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Close();
            Assert.Pass();
        }
    }
}