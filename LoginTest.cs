using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModelCsharp.Page;

namespace PageObjectModelCsharp.Test
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private LoginPage _loginPage;
		private readonly By _loggedInUsername = ByXpath("//*[contains(text(), 'qatestuser')]");

        
        [SetUp]
        public void Before()
        {
            _loginPage = new LoginPage(Driver);
        }
        
        [Test(Description = "Verify that a user can login to the application with valid credentials")]
        public void TestValidUserLogin()
        {
            _loginPage.Login("qatestuser", "RNNrq5dubcCNKtBwhALO");
					   
	   
            Assert.AreEqual("qatestuser", new Homepage(Driver)._loggedInUsername);
        }
        
        [Test(Description = "Verify that a user cannot login to the application with invalid credentials")]
        }