using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MySampleApp.StepDefinitions
{
    [Binding]
    public class CommodityFeatureSteps:Utilites
    {
        [When(@"I click on CTA link")]
public void WhenIClickOnCTALink()
{
    ChannelPage.CtaLink.Click();
            
}

        [Then(@"I should see tabs ""(.*)"", ""(.*)"",""(.*)"",""(.*)"",""(.*)"", ""(.*)"" on page")]
public void ThenIShouldSeeTabsOnPage(string howCanWeHelp, string marketOverView, string newsAndAnalysis, string services, string methodology, string about)
        {
            var tabs = new string[] {howCanWeHelp, marketOverView, newsAndAnalysis, services, methodology, about};

            var tabtexts = ChannelPage.AllTabTexts();
            foreach (var tab in tabs)
            {
                Assert.True(tabtexts.Contains(tab.ToLower()), "tab not displayed in TBC section :"+tab);

            }
        }

        [Then(@"I should see the '(.*)'")]
public void ThenIShouldSeeThe(string page)
{
    WaitForPageToLoad();
     Assert.AreEqual(page,Driver.Title);
}
    }
}
