/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;

namespace BookswagonProject.Base
{
    public class BaseClass
    {

        //initialization
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(TestClass));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());


        [SetUp]
        public void BrowserTest()
        {
            var fileInfo = new FileInfo(@"Log4net.config");
            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Entering Setup");
            try
            {
                //Creating an instance of chrome webdriver
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-notifications");
                driver = new ChromeDriver(options);
                driver.Url = "https://www.bookswagon.com/";
                log.Debug("navigating to url");
                // To maximize browser
                driver.Manage().Window.Maximize();
                log.Info("Exiting setup");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Takescreenshot()
        {
            //using interface Itakescreenshot
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\soubarnika.v\source\repos\BookswagonProject\BookswagonProject\Screenshots\OrderReview.png");

        }
        [TearDown]
        public void TearDown()
        {
            //closing the browser
            driver.Quit();
        }
    }
}
