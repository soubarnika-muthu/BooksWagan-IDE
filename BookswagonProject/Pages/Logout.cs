using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BookswagonProject.Pages
{
    public class Logout: Base.BaseClass
    {
        //initializing pagefactory method
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        [FindsBy(How = How.Id, Using = "ctl00_lblUser")]
        [CacheLookup]
        public IWebElement usermenu;

        [FindsBy(How = How.LinkText, Using = "Log out")]
        [CacheLookup]
        public IWebElement logoutOption;
    }
}
