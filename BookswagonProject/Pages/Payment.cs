/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonProject.Pages
{
   public  class Payment:Base.BaseClass
    {
        public Payment(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[3]/div[2]/div[1]/div[2]/div[3]/div[1]/ul[1]/li[4]/a[1]")]
        [CacheLookup]
        public IWebElement gift;

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        [CacheLookup]
        public IWebElement logout;

        
    }
}
