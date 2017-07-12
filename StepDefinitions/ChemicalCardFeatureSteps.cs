using System.Collections.Generic;
using System.Configuration;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MySampleApp.StepDefinitions
{
    [Binding]
    public class ChemicalCardFeatureSteps:Utilites
    {
        [Given(@"I view the '(.*)' page")]
public void GivenIViewThePage(string url)
{

            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]+url);
            WaitForPageToLoad();
    
}

        [Then(@"Links in channel card should be as follows")]
public void ThenLinksInChannelCardShouldBeAsFollows(Table table)
        {
            var rows = new List<string>();
            foreach (var row in table.Rows)
            {
                rows.Add(row["links"].ToLower());
            }


            foreach (var link in HomePage.LinksInChemicalCard )
            {
                   Assert.True(rows.Contains(link.Text.ToLower()));
            }


}
    }
}
