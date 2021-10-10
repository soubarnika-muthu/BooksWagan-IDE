/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonProject.Pages
{
    public class LoginPage : Base.BaseClass
    {
        //initializing pagefactory method
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        [FindsBy(How = How.LinkText, Using = "Login")]
        [CacheLookup]
        public IWebElement loginoption;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$btnLogin")]
        [CacheLookup]
        public IWebElement loginbt;
        
    }
}
