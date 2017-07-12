using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MySampleApp.PageObjects
{
   public class ChannelPage:Utilites
    {

       public ChannelPage()
       {
           PageFactory.InitElements(Driver,this);
       }

       [FindsBy(How = How.XPath, Using = "//*[@id='CommodityIntro']/div/ul/li/a")]
       public IWebElement CtaLink { set; get; }
       [FindsBy(How = How.CssSelector,Using = ".tab-item-header")]
       public IList<IWebElement> AllTabsInTbc { set; get; }




       public List<string> AllTabTexts()
       {

           var texts = new List<string>();
           
           foreach (var tab in AllTabsInTbc)
           {
               texts.Add(tab.Text.ToLower());
           }

           return texts;
       } 



    }
}
