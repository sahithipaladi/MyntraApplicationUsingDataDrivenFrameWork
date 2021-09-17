/*
 * project = Using DataDriven FrameWork with myntra application
 * Author =  sahithi paladi
 * Created Date = 15/09/2021
 */


using DataDrivenProjectForMyntra.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DataDrivenProjectForMyntra.Base
{
    public class ActionDo
    {
        public static LoginPage login;
        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Online Shopping for Women, Men, Kids Fashion & Lifestyle - Myntra";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
    }
}

       