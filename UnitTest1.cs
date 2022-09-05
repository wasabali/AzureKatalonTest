
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
        public void TheDepartementElementPresentTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.LinkText("Statsministerens kontor")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dep/smk/id875/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Regjeringen Støre 28. april 2022. Regjeringsmedlemmene står mot en blå bakgrunn med riksløver.']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Logoen til bærekraftsmålene']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Skjermbilde fra regjeringen.no']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Planlagte saker til Stortinget vårsesjonen 2022"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Offisielt frå statsråd"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[5]/div[3]/div/ul/li/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[5]/div[3]/div/ul/li[3]/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Nordiske flagg.']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Gul hveteåker og blå himmel']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[7]/div[2]/div/ul/li[4]/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[7]/div[2]/div/ul/li[8]/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//data[@value='Abonner på nyheitsvarsel']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//data[@value='Flere aktuelle saker']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[8]/div/div/div/div/ul/li/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Om r-konferanser"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.LinkText("Kunnskapsdepartementet")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dep/kd/id586/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Om departementet"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Nyheter"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Bilde av elever på videregående skole ']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Meld. St. 21 (2020–2021)"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Jente som sager planke']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.LinkText("Olje- og energidepartementet")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dep/oed/id750/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt=\"'\"]"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Fornybar energi"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Flom og skred"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Stortinget']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dep/oed/id750/");
            driver.FindElement(By.LinkText("Forsvarsdepartementet")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dep/fd/id380/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Forsvarsindustri"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Internasjonale operasjoner"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Norge også tidligere har trent ukrainske soldater i bruk av artilleriskytset M109 som Norge donerte. Treningen fant sted i Tyskland.']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Forsvarsminister Bjørn Arild Gram']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Illustrasjonsbilde: Vernepliktige soldater fra HMKG']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
        }
        
        [TestMethod]
        public void TheFinnTemaElementPresetTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            driver.FindElement(By.Id("megamenupanel_0_label")).Click();
            driver.FindElement(By.LinkText("Finn tema")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/tema/id208/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("TopicSearch"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div/div/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div/div[2]/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div[3]/div[4]/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div[4]/div[2]/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div[4]/div/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div[4]/div[5]/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div[3]/div[6]/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div/div[8]/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div[4]/div[8]/h2/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void TheForsideMenyElementPresentTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("megamenupanel_0_label"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("megamenupanel_1_label"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("megamenupanel_2_label"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("megamenupanel_3_label"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("megamenupanel_4_label"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("megamenupanel_0_label")).Click();
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.Id("megamenupanel_2_label")).Click();
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.Id("megamenupanel_4_label")).Click();
            driver.FindElement(By.XPath("//div[@id='megamenupanel_4']/div/div/p/a")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/om-regjeringa/id443314/");
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.LinkText("Departementene")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dep/id933/");
            driver.FindElement(By.Id("megamenupanel_2_label")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/aktuelt/id1150/");
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.LinkText("Finn dokument")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dokument/id2000006/");
            driver.FindElement(By.Id("megamenupanel_0_label")).Click();
            driver.FindElement(By.LinkText("Finn tema")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/tema/id208/");
            driver.FindElement(By.Id("megamenupanel_4_label")).Click();
            driver.FindElement(By.LinkText("Regjeringen Støre")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/om-regjeringa/stoere/regjeringen-store/id2877247/");
        }
        
        [TestMethod]
        public void TheNOUElementPresentTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.LinkText("NOU-ar")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dokument/nou-ar/id1767/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//a[contains(text(),'NOU 2022: 9 - En åpen og opplyst  offentlig samtale')]"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("NOU 2022: 2 - Akademisk ytringsfrihet"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("NOU 2021: 7 - Trygg og enkel eiendomsmegling"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerdocumenttype"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggertopic"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerownerid"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerfrom"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("mainsearch"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//form[@id='searchPageNavigationSearchForm']/fieldset/div/div/div[2]/button/data"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
        }
        
        [TestMethod]
        public void TheTalerInnleggKalenderElementPresentTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            driver.FindElement(By.Id("megamenupanel_2_label")).Click();
            driver.FindElement(By.LinkText("Taler og innlegg")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/aktuelt/taler_artikler/id1334/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Global outlook in a transformative decade"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Kraftsituasjonen  krever ærlige svar')]"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//form[@id='searchPageNavigationSearchForm']/fieldset/div/div/div[2]/button/data"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("mainsearch"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerdocumenttype"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggertopic"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerownerid"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerfrom"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("megamenupanel_2_label")).Click();
            driver.FindElement(By.LinkText("Kalender")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/aktuelt/kalender/id1330/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTrigger1"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("find-calendarevents-by-person"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("dp1"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
        }
        
        [TestMethod]
        public void TheForsideElementPresentTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Jonas Gahr Støre']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Endringer i lover og forskrifter fra 1. juli 2022"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[3]/div/ul/li[6]/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='En av løvestatuene foran Stortinget']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Grått kartutsnitt av Europa med Ukraina framhevet i blått.']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[6]/div[2]/div/div/h3/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[6]/div[4]/div/div[3]/h3/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[7]/div/div/div[2]/div/ul/li[20]/img"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.XPath("//main[@id='mainContent']/div")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//data[@value='Regjeringen.no']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
        }
        
        [TestMethod]
        public void TheStatsbudsjettElementPresentTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.LinkText("Statsbudsjettet 2022")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/statsbudsjett/2022/id2871447/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='bildet av skjette fyr']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//a[contains(text(),'Budsjettdokumenter og  pressemeldinger')]"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Se sendingen her']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Revidert budsjett 2022"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[3]/div/ul/li[5]/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Skatter og avgifter"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Tallene bak figurene"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Om statsbudsjetter"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Tidligere budsjetter"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='\"\"']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//img[@alt='Bilde av Jan Tore Sanner']"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Flere dokumenter"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[6]/div[2]/div/div[2]/h3/a"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
        }
        
        [TestMethod]
        public void TheHRingerElementPresentTest()
        {
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/id4/");
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.LinkText("Høyringar")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dokument/hoyringar/id1763/");
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Testhøring september"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Høyring - forslag til endringar i forskrift om sektoravgift og gebyr til Nasjonal kommunikasjonsmyndigheit"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("mainsearch"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//form[@id='searchPageNavigationSearchForm']/fieldset/div/div/div[2]/button/data"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div/div/div/div/div[2]/div/div/button"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerdocumenttype"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggertopic"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerownerid"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerfrom"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.LinkText("Kva er ei høyring?")).Click();
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dokument/hoyringar/kva-er-ei-hoyring/id2459635/");
            driver.Navigate().GoToUrl("https://dev.regjeringen.no/no/dokument/hoyringar/id1763/");
            driver.FindElement(By.Id("mainContent")).Click();
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Forrige"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            for (int second = 0;; second++) {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Neste"))) break;
                }
                catch (Exception)
                {}
                Thread.Sleep(1000);
            }
            driver.FindElement(By.XPath("//data[@value='Relevans']")).Click();
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
