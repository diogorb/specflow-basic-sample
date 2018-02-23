using NUnit.Framework;
using specflow.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace specflow
{
    [Binding]
    public class AngularMaterialComponentsSteps
    {
        [BeforeFeature]
        public static void setup()
        {
            BasePage.StartBrowser();
        }

        [AfterFeature]
        public static void tearDown()
        {
            BasePage.StopBrowser();
        }

        [Given(@"I went to menu ""(.*)"", submenu ""(.*)""")]
        public void GivenIWentToMenuSubmenu(string menu, string subMenu)
        {
            HomePage.clickMenu(menu);
            HomePage.clickSubMenu(subMenu);
        }
        
        [When(@"I fill the input field with ""(.*)""")]
        public void WhenIFillTheInputFieldWith(string text)
        {
            DialogPage.fillInput(text);
        }
        
        [When(@"select the Pick one option")]
        public void WhenSelectThePickOneOption()
        {
            DialogPage.clickPickOne();
        }
        
        [Then(@"should display a modal with the message ""(.*)""")]
        public void ThenShouldDisplayAModalWithTheMessage(string text)
        {
            Assert.IsTrue(DialogPage.getDialogTitle().Contains(text));
        }
    }
}
