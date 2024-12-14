using OpenQA.Selenium;

namespace SeleniumTest.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Locators
        public IWebElement ContactLink => _driver.FindElement(By.LinkText("Contact"));
        public IWebElement ShopLink => _driver.FindElement(By.LinkText("Shop"));

        // Methods
        public void GoToContactPage()
        {
            ContactLink.Click();
        }

        public void GoToShopPage()
        {
            ShopLink.Click();
        }
    }
}
