using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MySampleApp.PageObjects
{
    public class HomePage:Utilites
    {

        public HomePage()
        {
            PageFactory.InitElements(Driver,this);
        }


        [FindsBy(How = How.CssSelector,Using = ".rtx-ChemicalCard.control h4")]
        public IWebElement ChemicalCardHeader { set; get; }

        [FindsBy(How = How.CssSelector, Using = ".chemCommodities>li>a")]
        public IList<IWebElement> LinksInChemicalCard { set; get; }



    }
}
