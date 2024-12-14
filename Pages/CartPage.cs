using OpenQA.Selenium;

namespace SeleniumTest.Pages
{
    public class CartPage
    {
        private IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        // Method to get product price
        public decimal GetProductPrice(string productName)
        {
            var priceLocator = _driver.FindElement(By.XPath($"//tr[td[text()='{productName}']]/td[contains(@class, 'Price')]/span"));
            return decimal.Parse(priceLocator.Text.Replace("$", "").Trim());
        }

        public decimal GetProductSubtotal(string productName)
        {
            var subtotalLocator = _driver.FindElement(By.XPath($"//tr[td[text()='{productName}']]/td[contains(@class, 'Subtotal')]/span"));
            return decimal.Parse(subtotalLocator.Text.Replace("$", "").Trim());
        }

        public decimal GetTotal()
        {
            var totalLocator = _driver.FindElement(By.XPath("//td[contains(@class, 'Total')]/span"));
            return decimal.Parse(totalLocator.Text.Replace("$", "").Trim());
        }
    }
}
