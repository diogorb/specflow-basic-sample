using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specflow.PageObjects
{
    class BasePage
    {
        private static WebDriverWait browserWait;

        private static IWebDriver browser;

        public static string base_url = "https://material.angular.io/components/categories";

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    BasePage.StartBrowser();
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        public static void StartBrowser(int defaultTimeOut = 30)
        {
            BasePage.browser = new ChromeDriver(@"C:\chromedriver");
            BasePage.browserWait = new WebDriverWait(BasePage.browser, TimeSpan.FromSeconds(defaultTimeOut));
            BasePage.browser.Navigate().GoToUrl(BasePage.base_url);

        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
