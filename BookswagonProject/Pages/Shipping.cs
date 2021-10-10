/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace BookswagonProject.Pages
{
  public  class Shipping:Base.BaseClass
    {
        public Shipping(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[3]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/a[1]")]
        [CacheLookup]
        public IWebElement continuebt;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewRecipientName")]
        [CacheLookup]
        public IWebElement Name;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewCompanyName")]
        [CacheLookup]
        public IWebElement CMname;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewAddress")]
        [CacheLookup]
        public IWebElement address;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCountry")]
        [CacheLookup]
        public IWebElement country;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewState")]
        [CacheLookup]
        public IWebElement State;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCities")]
        [CacheLookup]
        public IWebElement city;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewPincode")]
        [CacheLookup]
        public IWebElement pincode;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewMobile")]
        [CacheLookup]
        public IWebElement phone;

        /* [FindsBy(How = How.Name, Using = "ctl00_cpBody_chkNewDefault")]
         [CacheLookup]
         public IWebElement select;*/

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$imgSaveNew")]
        [CacheLookup]
        public IWebElement save;
    }
}
