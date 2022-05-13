
using OpenQA.Selenium;

namespace PageObjectModelCsharp.Page
{
    public class HomePage : BasePage
    {
        
		private readonly By _loggedInUsername = ByXpath("//*[@class="panel-heading"]/h2/text()");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public string GetLoggedInUsername()
        {
            return GetElement(_loggedInUsername).Text;
        }
    }
}