using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_bot_template
{
    partial class Bot
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait wait { get; set; }
        public IJavaScriptExecutor JS { get; set; }

        public IWebDriver EnterWithChrome()
        {
            Driver = new FirefoxDriver();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            return Driver;
        }

        public IWebDriver EnterWithFirefox()
        {
            Driver = new FirefoxDriver();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            return Driver;
        }

        public void BotActions()
        {
            Wait(20000);

        }
    }
}
