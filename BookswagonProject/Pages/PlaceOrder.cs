/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace BookswagonProject.Pages
{
    public class PlaceOrder : Base.BaseClass
    {
        //initializing pagefactory method
        public PlaceOrder(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[4]/div[4]/table[1]/tbody[1]/tr[3]/td[1]/div[1]/a[1]/input[1]")]
        [CacheLookup]
        public IWebElement buynow_bt;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[2]/div[1]/div[1]/div[4]/table[1]/tbody[1]/tr[1]/td[3]/input[1]")]
        [CacheLookup]
        public IWebElement Placeorder_bt;

        [FindsBy(How = How.Id, Using = "BookCart_lvCart_ctrl0_txtQty")]
        [CacheLookup]
        public IWebElement quantity;

        [FindsBy(How = How.Id, Using = "BookCart_lvCart_ctrl0_imgUpdate")]
        [CacheLookup]
        public IWebElement refresh;

        
    }
}
