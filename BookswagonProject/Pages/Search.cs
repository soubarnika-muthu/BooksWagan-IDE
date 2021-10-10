using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonProject.Pages
{
    public class Search
    {
        public Search(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "ctl00$TopSearch1$txtSearch")]
        [CacheLookup]
        public IWebElement search;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[3]/div[2]/div[1]/div[4]/div[5]/a[2]/input[1]")]
        [CacheLookup]
        public IWebElement wishlist;
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[2]")]
        [CacheLookup]
        public IWebElement checkwishlist;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[3]/div[1]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement invalidsearch;



    }
}
