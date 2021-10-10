/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BookswagonProject.Pages
{
   public class ReviewOrder:Base.BaseClass
    {
        public ReviewOrder()
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ShoppingCart$lvCart$savecontinue")]
        [CacheLookup]
        public IWebElement reviewbtn;
        //body[1]/form[1]/div[3]/div[3]/div[2]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[3]/div[2]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]")]
        [CacheLookup]
        public IWebElement reviewbook;
    }
}
