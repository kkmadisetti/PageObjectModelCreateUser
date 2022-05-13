using OpenQA.Selenium;

namespace PageObjectModelCsharp.Page
{
    public class LoginPage : BasePage
    {
        private readonly By _emailTextBox = By.Id("edit-name");
        private readonly By _passwordTextBox = By.Id("edit-pass");
        private readonly By _signInButton = By.Id("edit-submit");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        
        public void SetUsername(string username)
        {
            SendKeys(_usernameTextBox, username);
        }
        
        public void SetPassword(string password)
        {
            SendKeys(_passwordTextBox, password);
        }

        public void ClickLoginButton()
        {
            Click(_loginButton);
        }

        public void Login(string email, string password)
        {
            SetUsername(username);
            SetPassword(password);
            ClickLoginButton();
        }
    }
}