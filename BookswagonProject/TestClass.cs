/*Project =Selenium Automation Testing -BooksWagan 
 * created by = Soubarnika Muthu
 * date = 05/10/2021
 */
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace BookswagonProject
{
    [TestFixture]
    [AllureNUnit]
    // [AllureDisplayIgnored]
    public class TestClass : Base.BaseClass
    {
        //checking with valid login credentials
        [Test, Order(0)]
        public void Test_Signup()
        {
            Action.DoAction.Registeration();

        }
        ///
        [Test(Description = "login")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        public void Test_Login()
        {
            Action.DoAction.LoginIn();
        }
        [Test]
        public void Test_Search()
        {
            Action.DoAction.SearchBook();
        }
        [Test]
        public void Test_Wishlist()
        {
            Action.DoAction.Add_to_Wishlist();
        }
        [Test]
        public void Test_Placeorder()
        {
            Action.DoAction.PlaceOrder();
        }
        [Test]
        public void Test_Shipping()
        {
            Action.DoAction.ShippingAddress();
        }
        [Test]
        public void Test_OrderReview()
        {
            Action.DoAction.OrderReview();
        }
        [Test]
        public void Test_Payment()
        {
            Action.DoAction.Make_Payment();
        }
        [Test]
        public void Test_Logout()
        {
            Action.DoAction.Logout();
        }
        [Test]
        public void Test_Invalid_login()
        {
            Action.NegativeTestCases.Invalid_Password();
        }
        [Test]
        public void Test_Invalid_Signup()
        {
            Action.NegativeTestCases.Invalid_Registeration();
        }
        [Test]
        public void Test_Invalid_Seacrch()
        {
            Action.NegativeTestCases.Invalid_Search();
        }
    }
}
