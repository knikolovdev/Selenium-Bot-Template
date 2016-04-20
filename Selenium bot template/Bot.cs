using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
            Log("Starting Chrome.");
            Driver = new ChromeDriver();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            return Driver;
        }

        public IWebDriver EnterWithChrome(string proxyAddress)
        {
            Log("Starting Chrome.");
            Log("Using proxy: " + proxyAddress);
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--proxy-server=" + proxyAddress);
            Driver = new ChromeDriver();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            return Driver;
        }

        public IWebDriver EnterWithFirefox()
        {
            Log("Starting Firefox.");
            Driver = new FirefoxDriver();
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            return Driver;
        }

        public IWebDriver EnterWithFirefox(string proxyAddress)
        {
            Log("Starting Firefox.");
            Log("Using proxy: " + proxyAddress);
            FirefoxProfile profile = new FirefoxProfile();
            Proxy proxy = new Proxy();
            proxy.HttpProxy = proxyAddress;
            proxy.FtpProxy = proxyAddress;
            proxy.SslProxy = proxyAddress;
            profile.SetProxyPreferences(proxy);
            Driver = new FirefoxDriver(profile);
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            JS = Driver as IJavaScriptExecutor;
            return Driver;
            //
        }

        public void Log(string text)
        {
            MainWindow.UI.Dispatcher.Invoke((Action)(() =>
            {
                MainWindow.UI.LogBox.Text += text + "\n";
            }));
        }

        public void TestProxy()
        {
            EnterWithFirefox();
            GoTo("http://myexternalip.com");
        }

        public void BotActions()
        {
            EnterWithFirefox();
        }
    }
}
