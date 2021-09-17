/*
 * project = Using DataDriven FrameWork with myntra application
 * Author =  sahithi paladi
 * Created Date = 15/09/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DataDrivenProjectForMyntra.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//span[@class = 'desktop-userTitle']")]
        [CacheLookup]
        public IWebElement profileButton;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'desktop-getUserInLinks desktop-getInLinks']")]
        [CacheLookup]
        public IWebElement signButton;

        [FindsBy(How = How.XPath, Using = "//input[@class='form-control mobileNumberInput']")]
        [CacheLookup]
        public IWebElement mobileNumber;


        [FindsBy(How = How.XPath, Using = "//div[@class='submitBottomOption']")]
        [CacheLookup]
        public IWebElement CONTINUEButton;

    }
}