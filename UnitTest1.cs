
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestClass]
    public class RV71Prod
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;


        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TestAvForsiden()
        {
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/id4/");
            driver.FindElement(By.LinkText("UDs reiseinformasjon")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/tema/utenrikssaker/reiseinformasjon/id2413163/");
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/id4/");
            driver.FindElement(By.XPath("//img[@alt='To riksløver og teksten Norge og Departementene']")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            driver.FindElement(By.XPath("//img[@alt='Portrett av finansminister Trygve Slagsvold Vedum mot en grå bakvegg.']")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/aktuelt/presseinvitasjon-finansministerens-foredrag-for-budsjettkonferansen/id2925434/");
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/id4/");
            driver.FindElement(By.XPath("//main[@id='mainContent']/div/div[5]/div[3]/div/div[2]/h3/a")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/tema/naringsliv/id926/");
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/id4/");
            driver.FindElement(By.XPath("//main[@id='mainContent']/div/div[6]/div/div/div[2]/button[2]")).Click();
            driver.FindElement(By.XPath("//main[@id='mainContent']/div/div[6]/ul/li[3]/a")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/om-regjeringa/slik-blir-norge-styrt/id85844/");
        }

        [TestMethod]
        public void TheRV71EngelskProdTest()
        {
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/id4/");
        }

        

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
