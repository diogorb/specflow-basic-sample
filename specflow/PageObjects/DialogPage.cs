using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specflow.PageObjects
{
    class DialogPage : BasePage
    {
        public static string input = "[placeholder=\"What's your name?\"]";
        public static string pickOne = "[class='mat-raised-button']";
        public static string dialogTitle = "h1.mat-dialog-title";

        public static void fillInput(string text)
        {
            BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(DialogPage.input)));
            Browser.FindElement(By.CssSelector(DialogPage.input)).SendKeys(text);
        }

        public static void clickPickOne()
        {
            Browser.FindElement(By.CssSelector(DialogPage.pickOne)).Click();
        }

        public static string getDialogTitle()
        {
            BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(DialogPage.dialogTitle)));
            return Browser.FindElement(By.CssSelector(DialogPage.dialogTitle)).Text;
        }

    }
}
