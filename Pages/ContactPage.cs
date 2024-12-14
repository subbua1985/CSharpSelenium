using OpenQA.Selenium;

namespace SeleniumTest.Pages
{
    public class ContactPage
    {
        private readonly IWebDriver _driver;

        public ContactPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Fill the contact form
        public void FillForm(string name, string email, string message)
        {
            _driver.FindElement(By.Name("name")).SendKeys(name);
            _driver.FindElement(By.Name("email")).SendKeys(email);
            _driver.FindElement(By.Name("message")).SendKeys(message);
        }

        // Click Submit button
        public void ClickSubmit()
        {
            _driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        // Method to check if error messages are visible
        public bool AreErrorMessagesVisible()
        {
            try
            {
                var errorMessage = _driver.FindElement(By.CssSelector("#header-message"));
                return errorMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false; // If the error message is not found, return false
            }
        }

        // Method to check if success message is visible
        public bool IsSuccessMessageVisible()
        {
            try
            {
                var successMessage = _driver.FindElement(By.CssSelector("#success-message"));
                return successMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
