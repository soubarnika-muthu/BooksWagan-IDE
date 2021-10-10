/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace BookswagonProject.Pages
{
   public class RegistrationPage : Base.BaseClass
    {
     
            //initializing pagefactory method
            public RegistrationPage(IWebDriver driver)
            {
                PageFactory.InitElements(driver, this);
                
            }
            // Using FindBy for locating elements
            [FindsBy(How = How.LinkText, Using = "Signup")]
            [CacheLookup]
            public IWebElement signupbt;

            [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtEmail")]
            [CacheLookup]
            public IWebElement regemail;

            [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtPassword")]
            [CacheLookup]
            public IWebElement regpassword;

            [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_txtConfirmPwd")]
            [CacheLookup]
            public IWebElement confirm_pwd;

            [FindsBy(How = How.Id, Using = "ctl00_phBody_SignUp_chkNewsletter")]
            [CacheLookup]
            public IWebElement checkbox;

            [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$btnSubmit")]
            [CacheLookup]
            public IWebElement createaccount_bt;


        }
    }
