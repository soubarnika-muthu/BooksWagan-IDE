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
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace BookswagonProject.Action
{
    public class NegativeTestCases:Base.BaseClass
    {
        public static RegistrationPage register;
        //Get Logger for fully qualified name for type of 'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(TestClass));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        public static void Invalid_Password()
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
                login.email.SendKeys(ExcelOperations.ReadData(2, "email"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(2, "password"));
                System.Threading.Thread.Sleep(2000);
                
                login.loginbt.Click();
                System.Threading.Thread.Sleep(4000);
                string expected = "Please enter correct Email or Password.";
                string actual = driver.FindElement(By.Id("ctl00_phBody_SignIn_lblmsg")).Text;
                //Console.WriteLine("Error Message: {0}", actual);
                if (expected.Equals(actual))
                {
                    Console.WriteLine("Given Error Message: {0}", actual);
                }
                else
                {
                    Console.WriteLine("Testcase Failed");
                }
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
        public static void Invalid_Registeration()
        {
            try
            {
                RegistrationPage register = new RegistrationPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\BookswagonProject\BookswagonProject\TestDataFiles\Bookswagon_TestData.xlsx");
                Debug.WriteLine("**");
                register.signupbt.Click();
                System.Threading.Thread.Sleep(2000);
                //Reads data from excel file and enters data into webpage using sendkeys method
                register.regemail.SendKeys(ExcelOperations.ReadData(3, "email"));
                System.Threading.Thread.Sleep(2000);

                register.regpassword.SendKeys(ExcelOperations.ReadData(3, "password"));
                System.Threading.Thread.Sleep(2000);

                register.confirm_pwd.SendKeys(ExcelOperations.ReadData(3, "confirmpassword"));
                System.Threading.Thread.Sleep(2000);
                string expected = "Password Mismatch";
                string actual = driver.FindElement(By.Id("ctl00_phBody_SignUp_cvPassword")).Text;
                //Console.WriteLine("Error Message: {0}", actual);
                if (expected.Equals(actual))
                {
                    Console.WriteLine("Given Error Message: {0}", actual);
                }
                else
                {
                    Console.WriteLine("Testcase Failed");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Invalid_Search()
        {
            try
            {
                
                //creating instance
                Pages.Search search = new Pages.Search(driver);
                search.search.SendKeys("===");
                search.search.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(4000);
                string expected = "Your search - \" === \" - did not match any books.";
                string actual = search.invalidsearch.Text;
                Assert.AreEqual(actual, expected);

                if (expected.Equals(actual))
                {
                    Console.WriteLine("Given Error Message: {0}", actual);
                }
                else
                {
                    Console.WriteLine("Testcase Failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
