using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specflow.PageObjects
{
    class HomePage : BasePage
    {
        public static void clickMenu(string menuItem)
        {
            Browser.FindElement(By.CssSelector("[aria-label='" + menuItem + "']")).Click();
        }

        public static void clickSubMenu(string menuItem)
        {
            Browser.FindElement(By.CssSelector("[href='/components/" + menuItem + "']")).Click();
        }
    }
}
