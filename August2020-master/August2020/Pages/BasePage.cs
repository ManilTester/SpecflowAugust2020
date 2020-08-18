using OpenQA.Selenium;

namespace August2020.Pages
{
    public abstract class BasePage
    {
        public IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
