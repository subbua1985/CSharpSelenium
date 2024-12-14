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

        // Locators for Contact and Shop
        public IWebElement ContactLink => _driver.FindElement(By.LinkText("Contact"));
        public IWebElement ShopLink => _driver.FindElement(By.LinkText("Shop"));

        // Methods to Click Contact page
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
