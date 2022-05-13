
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModelCsharp.Page;

namespace PageObjectModelCsharp.Test
{
    [TestFixture]
    public class CreateUserTest : BaseTest
    {
        private LoginPage _loginPage;
		private Homepage _homePage;
		
		string importParticipantsxpath = "//*[@id="body-container"]/div/div/section/ul/li[2]/a/text()";
		stringtring importParticipantTitle = "//*[contains(text(),'Import Participants')]"
        string browsexpath = "//span[contains(text(),'Browse...')]";
		string cvsFilepath = "C:\temp\Participants.csv";
		string importxpath = "//button[@id='edit-submit']";
		string messageXpath = "//*[contains(text(),'Updated 1 user.')]"
        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(Driver);
			 _homePage = new homePage(Driver);
        }
        
        [Test(Description = "Verify that a user can login to the application with valid credentials")]
        public void TestValidUserLogin()
        {
            _loginPage.Login("qatestuser", "RNNrq5dubcCNKtBwhALO");
				
			IWebElement menuHoverLink = findElementByLocator(locatorType, menuTitle);
			//now we hover it with mouse
			actions.moveToElement(menuHoverLink).perform();
			//let's find our menu item
			WebElement menuItemElement = findElementByLocator(locatorType, menuItem);
			actions.moveToElement(menuItemElement);
			actions.click().build().perform();  
			Click(By.Xpathpathth(importParticipantsxpath));
			driver.SwitchTo().Frame(By.Xpath(importParticipantTitle)); 		   
			Click(By.Xpath(browsexpath));
			SendKeys(By.Xpath(cvsFilepath));
		    Click(By.Xpath(importxpath));
            Assert.AreEqual("Updated 1 user.", By.Xpath(messageXpath));
        }
        
        [Test(Description = "Verify that a new user created successfully after login to the application with valid credentials")]
        }




 