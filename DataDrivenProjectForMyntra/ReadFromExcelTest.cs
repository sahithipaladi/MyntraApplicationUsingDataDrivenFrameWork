/*
 * project = Using DataDriven FrameWork with myntra application
 * Author =  sahithi paladi
 * Created Date = 15/09/2021
 */

using DataDrivenProjectForMyntra.Pages;
using NUnit.Framework;
using System;

namespace DataDrivenProjectForMyntra
{
    public class ReadFromExcelTest : Base.BaseClass
    {
        [Test]
        public void ReadingDataFromExcelAndLoginIntoMyntra()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\sahithi.p\source\repos\DataDrivenProjectForMyntra\DataDrivenProjectForMyntra\TestLoginDetails.xlsx");

            LoginPage login = new LoginPage(driver);

            login.profileButton.Click();
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("profileButton is clicked sucessfully");

            login.signButton.Click();
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("signButton is clicked sucessfully");


            login.mobileNumber.SendKeys(ExcelOperations.ReadData(1, "mobileNumber"));
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("mobileNumber is entered sucessfully");

            login.CONTINUEButton.Click();
            System.Threading.Thread.Sleep(12000);
            Console.WriteLine("CONTINUEButton is clicked sucessfully");





        }
    }
}
