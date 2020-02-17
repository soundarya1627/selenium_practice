using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumSession1
{
    public class Scenario
    {
        public void LoginApplication()
        {
            Console.Out.WriteLine("Login Application Functionality");


            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://google.com");

            driver.Quit();
        }
    }
}
