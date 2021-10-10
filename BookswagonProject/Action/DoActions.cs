/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using BookswagonProject.Operations;
using BookswagonProject.Pages;
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Reflection;


namespace BookswagonProject.Action
{
    public class DoAction : Base.BaseClass
    {
        public static RegistrationPage register;
        //Get Logger for fully qualified name for type of 'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(TestClass));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        //Method to check title of webpage
        public static void Assert_Titleof_Webpage()
        {
            string title1 = "Online Bookstore | Buy Books Online | Read Books Online";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        //Method to enter login credentials into webpage
        public static void Registeration()
        {
            try
            {
                register = new RegistrationPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\BookswagonProject\BookswagonProject\TestDataFiles\Bookswagon_TestData.xlsx");
                Debug.WriteLine("**");
                register.signupbt.Click();
                System.Threading.Thread.Sleep(2000);
                //Reads data from excel file and enters data into webpage using sendkeys method
                register.regemail.SendKeys(ExcelOperations.ReadData(1, "email"));
                System.Threading.Thread.Sleep(2000);

                register.regpassword.SendKeys(ExcelOperations.ReadData(1, "password"));
                System.Threading.Thread.Sleep(2000);

                register.confirm_pwd.SendKeys(ExcelOperations.ReadData(1, "confirmpassword"));
                System.Threading.Thread.Sleep(2000);

                if (register.checkbox.Selected)
                {
                    register.checkbox.Click();
                }
                System.Threading.Thread.Sleep(2000);
                //Takescreenshot();
                //using the click function 
                register.createaccount_bt.Click();
                System.Threading.Thread.Sleep(4000);

            }
            catch (Exception ex)
            {
                log.Error("Registeration failed");
                Console.WriteLine(ex.Message);
            }
        }
        public static void LoginIn()
        {
            try
            {
                LoginPage login = new LoginPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\BookswagonProject\BookswagonProject\TestDataFiles\Bookswagon_TestData.xlsx");
                Debug.WriteLine("**");
                login.loginoption.Click();
                System.Threading.Thread.Sleep(2000);
                //Reads data from excel file and enters data into webpage using sendkeys method
                login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
                System.Threading.Thread.Sleep(2000);
                //Takescreenshot();
                login.loginbt.Click();
                System.Threading.Thread.Sleep(4000);
                String actualUrl = "https://www.bookswagon.com/myaccount.aspx";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);

                if (expectedUrl.Equals(actualUrl))
                {
                    log.Info("Login Successful");
                }
                else
                {
                    log.Error("Login Failed");
                }

            }

            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver not able to find element");
            }
        }
        public static void SearchBook()
        {
            try
            {
                LoginIn();
                //creating instance
                Pages.Search search = new Pages.Search(driver);
                search.search.SendKeys("APJ");
                //Takescreenshot();
                search.search.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(4000);
                String actualUrl = "https://www.bookswagon.com/search-books/apj";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);

                if (expectedUrl.Equals(actualUrl))
                {
                    log.Info("Search Successful");
                }
                else
                {
                    log.Error("Search Failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void Add_to_Wishlist()

        {
            try
            {
                LoginIn();
                //creating instance
                Pages.Search search = new Pages.Search(driver);
                search.search.SendKeys("APJ");
                search.search.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(4000);
                search.wishlist.Click();
                System.Threading.Thread.Sleep(2000);
                //Takescreenshot();
                string checktext = "India 2020";
                if (search.checkwishlist.Text.Contains(checktext))
                {
                    log.Info("Added to wishlist successfully");
                }
                else
                {
                    log.Error("Adding to Wishlist Failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void PlaceOrder()
        {
            try
            {
                Add_to_Wishlist();
                PlaceOrder order = new PlaceOrder(driver);

                order.buynow_bt.Click();
                System.Threading.Thread.Sleep(4000);
                driver.SwitchTo().Frame(0);
                order.quantity.SendKeys(Keys.Backspace);
                System.Threading.Thread.Sleep(2000);
                order.quantity.SendKeys("2");
                System.Threading.Thread.Sleep(2000);
                order.refresh.Click();
                System.Threading.Thread.Sleep(4000);
                //Takescreenshot();
                order.Placeorder_bt.Click();
                System.Threading.Thread.Sleep(4000);

                String actualUrl = "https://www.bookswagon.com/checkout-login";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);
                try
                {
                    log.Info("Place Order Successful");
                }
                catch
                {
                    log.Error("PlaceOrder Failed");
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "Webdriver not able to find element");
            }

        }
        public static void ShippingAddress()
        {
            try
            {
                PlaceOrder();
                Pages.Shipping shipping = new Pages.Shipping(driver);
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\BookswagonProject\BookswagonProject\TestDataFiles\ShippingData.xlsx");
                Debug.WriteLine("****");
                shipping.continuebt.Click();
                System.Threading.Thread.Sleep(4000);

                shipping.Name.SendKeys(ExcelOperations.ReadData(1, "Name"));
                System.Threading.Thread.Sleep(2000);

                shipping.CMname.SendKeys(ExcelOperations.ReadData(1, "CmpName"));
                System.Threading.Thread.Sleep(2000);
                Takescreenshot();
                shipping.address.SendKeys(ExcelOperations.ReadData(1, "Address"));
                System.Threading.Thread.Sleep(2000);

                shipping.country.SendKeys(ExcelOperations.ReadData(1, "Country"));
                System.Threading.Thread.Sleep(2000);

                shipping.State.SendKeys(ExcelOperations.ReadData(1, "State"));
                System.Threading.Thread.Sleep(2000);

                shipping.city.SendKeys(ExcelOperations.ReadData(1, "City"));
                System.Threading.Thread.Sleep(2000);

                shipping.pincode.SendKeys(ExcelOperations.ReadData(1, "Pincode"));
                System.Threading.Thread.Sleep(2000);

                shipping.phone.SendKeys(ExcelOperations.ReadData(1, "Mobile"));
                System.Threading.Thread.Sleep(4000);

                shipping.save.Click();
                System.Threading.Thread.Sleep(4000);
                String actualUrl = "https://www.bookswagon.com/viewshoppingcart.aspx";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);
                try
                {

                    log.Info("Added Shipping address Successfully");
                }
                catch
                {
                    log.Error("Add Shipping Address Failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void OrderReview()
        {
            ShippingAddress();
            ReviewOrder review = new ReviewOrder();
            string checktext = "India 2020";
            if (review.reviewbook.Text.Contains(checktext))
            {
                log.Info("Order Reviewed successfully");
            }
            else
            {
                log.Error("Order Review Failed");
            }
            //Takescreenshot();
            review.reviewbtn.Click();
            System.Threading.Thread.Sleep(2000);
        }
        public static void Make_Payment()
        {
            try
            {
                OrderReview();
                Payment payment = new Payment(driver);
                //Takescreenshot();
                payment.gift.Click();
                System.Threading.Thread.Sleep(2000);
                String actualUrl = "https://www.bookswagon.com/checkout.aspx";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);
                try
                {

                    log.Info("Making Payments");
                }
                catch
                {
                    log.Error("Payment  Failed");
                }
                payment.logout.Click();
                String actualUrl1 = "https://www.bookswagon.com/login";
                String expectedUrl1 = driver.Url;
                Assert.AreEqual(actualUrl1, expectedUrl1);
                try
                {

                    log.Info("Logout Successful");
                }
                catch
                {
                    log.Error("Logout Failed");
                }
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
        }
        public static void Logout()

        {
            LoginIn();
            //creating instance
            Logout logout = new Logout(driver);
            logout.usermenu.Click();
            System.Threading.Thread.Sleep(4000);
            //Takescreenshot();
            logout.logoutOption.Click();
            System.Threading.Thread.Sleep(2000);
            String actualUrl = "https://www.bookswagon.com/login";
            String expectedUrl = driver.Url;
            Assert.AreEqual(actualUrl, expectedUrl);
            try
            {

                log.Info("Logout Successful");
            }
            catch
            {
                log.Error("Logout Failed");
            }


        }

    }
}
