using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;

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
        public void TheRV71ProdTest()
        {
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/id4/");
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("statsbudsjettet 2020");
            driver.FindElement(By.Id("topNavigationSearchForm")).Submit();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/?term=statsbudsjettet+2020");
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("searchResultsListing"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            try
            {
                Assert.AreEqual("7. oktober 2019 la regjeringen Solberg frem sitt forslag til statsbudsjett og nasjonalbudsjett for 2020.", driver.FindElement(By.XPath("//ul[@id='searchResultsListing']/li[3]/p")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Statsbudsjettet 2020", driver.FindElement(By.XPath("//ul[@id='searchResultsListing']/li[3]/h2")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("Statsbudsjettet 2020")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/statsbudsjett/2020/id2705757/");
            try
            {
                Assert.AreEqual("Statsbudsjettet 2020 - regjeringen.no", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Statsbudsjettet 2000'])[1]/following::span[2]")).Click();
            driver.FindElement(By.LinkText("Revidert nasjonalbudsjett 2020")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/statsbudsjett/2020/rnb/id2715690/");
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("statsbudsjettet 2020");
            driver.FindElement(By.Id("topNavigationSearchForm")).Submit();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/?term=statsbudsjettet+2020");
            driver.FindElement(By.LinkText("Statsbudsjettet 2020: Trøndelag")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/statsbudsjett/2020/statsbudsjettet-2020-fylkesoversikten/statsbudsjettet-2020-trondelag/id2714647/");
            try
            {
                Assert.AreEqual("Statsbudsjettet 2020: Trøndelag - regjeringen.no", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("statsbudsjettet 2020");
            driver.FindElement(By.Id("topNavigationSearchForm")).Submit();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/?term=statsbudsjettet+2020");
            driver.FindElement(By.LinkText("Statsbudsjettet 2020: Oslo")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/statsbudsjett/2020/statsbudsjettet-2020-fylkesoversikten/statsbudsjettet-2020-oslo/id2714489/");
            try
            {
                Assert.AreEqual("Statsbudsjettet 2020: Oslo - regjeringen.no", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.LinkText("Finn dokument")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dokument/id2000006/");
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerdocumenttype"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggertopic"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerownerid"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerfrom"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.LinkText("Høyringar")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dokument/hoyringar/id1763/");
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerdocumenttype"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("customSelectorTriggertopic")).Click();
            driver.FindElement(By.XPath("//div[@id='searchFilters']/ul/li[2]")).Click();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggertopic"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerownerid"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.Id("customSelectorTriggerfrom"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("customSelectorTriggerdocumenttype")).Click();
            driver.FindElement(By.XPath("//ul[@id='customSelectordocumenttype']/li/a")).Click();
            driver.FindElement(By.Id("customSelectorTriggertopic")).Click();
            driver.FindElement(By.XPath("//ul[@id='customSelectortopic']/li[2]/a")).Click();
            driver.FindElement(By.Id("customSelectorTriggerownerid")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Arbeids- og inkluderingsdepartementet\n                            (133)')]")).Click();
            driver.FindElement(By.Id("customSelectorTriggerfrom")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'2022\n                            (9)')]")).Click();
            try
            {
                Assert.AreEqual("30.06.2022", driver.FindElement(By.XPath("//ul[@id='searchResultsListing']/li/div/span")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Høyringar - regjeringen.no", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("Høring  Forslag til endringer i arbeidsmiljøloven mv.  tilpasninger av regelverket for yrkesdykking")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dokumenter/horing-forslag-til-endringer-i-arbeidsmiljoloven-mv.-tilpasninger-av-regelverket-for-yrkesdykking/id2921633/");
            try
            {
                Assert.AreEqual("Høring  Forslag til endringer i arbeidsmiljøloven mv.  tilpasninger av regelverket for yrkesdykking - regjeringen.no", driver.Title);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("historisk arkiv");
            driver.FindElement(By.Id("topNavigationSearchForm")).Submit();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/?term=historisk+arkiv");
            driver.FindElement(By.XPath("//main[@id='mainContent']/div/div/div/div/div/div/p/a")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dokumentarkiv/id115322/");
            driver.FindElement(By.Id("mainsearch")).Click();
            driver.FindElement(By.Id("mainsearch")).Clear();
            driver.FindElement(By.Id("mainsearch")).SendKeys("familie");
            driver.FindElement(By.Id("searchPageNavigationSearchForm")).Submit();
            driver.FindElement(By.Id("customSelectorTriggerdocumenttype")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Svar til Stortinget\n                            (457)')]")).Click();
            driver.FindElement(By.Id("customSelectorTriggergovernment")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Regjeringen Stoltenberg II\n                            (104)')]")).Click();
            driver.FindElement(By.Id("customSelectorTriggerutid")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Landbruks- og matdepartementet\n                            (7)')]")).Click();
            driver.FindElement(By.Id("customSelectorTriggerfrom")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'2006\n                            (1)')]")).Click();
            driver.FindElement(By.LinkText("Redegjørelse for Stortinget 28. mars 2006 om E.coli O 103, ved Landbruks- og matminister Terje Riis-Johansen")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dokumentarkiv/stoltenberg-ii/lmd/svar-til-stortinget/sporretimesporsmal/2006/redegjorelse-for-stortinget-28-mars-2006/id469786/");
            try
            {
                Assert.AreEqual("Redegjørelse for Stortinget 28. mars 2006 om E.coli O 103, ved Landbruks- og matminister Terje Riis-Johansen", driver.FindElement(By.XPath("//main[@id='mainContent']/div/div/div/header/h1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("megamenupanel_0_label")).Click();
            driver.FindElement(By.LinkText("Finn tema")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/tema/id208/");
            driver.FindElement(By.Id("TopicSearch")).Click();
            try
            {
                Assert.AreEqual("Energi", driver.FindElement(By.XPath("//main[@id='mainContent']/div/div[2]/div/div[3]/div[2]/div/div/div[3]/h2/a")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Energi- og petroleumsforskning", driver.FindElement(By.LinkText("Energi- og petroleumsforskning")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.LinkText("Fornybar energi")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/tema/energi/fornybar-energi/id2000124/");
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.LinkText("Kommunal- og distriktsdepartementet")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dep/kdd/id504/");
            try
            {
                Assert.AreEqual("Kommunal- og distriktsdepartementet", driver.FindElement(By.XPath("//main[@id='mainContent']/div/div/div/div/h1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("//main[@id='mainContent']/div/div[6]/div[3]/p/a")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dokument/id2000006/?ownerid=504");
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dokument/id2000006/?ownerid=504");
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.LinkText("Kommunal- og distriktsdepartementet")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dep/kdd/id504/");
            driver.FindElement(By.XPath("//main[@id='mainContent']/div/div[9]/div/div/div/div/ul/li/a")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/aktuelt/nyheter/id2006120/?ownerid=504");
            try
            {
                Assert.AreEqual("Nyheter og pressemeldinger", driver.FindElement(By.XPath("//main[@id='mainContent']/div/div/div/h1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/dep/smk/organisasjonskart/statsminister-jonas-gahr-store/id2877186/?vis=taler_og_innlegg");
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Statsminister Jonas Gahr Støres tale på minnearrangementet på Utøya 22. juli 2022"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Statsminister Jonas Gahr Støres tale i regjeringskvartalet 22. juli 2022"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Statsministerens tale ved åpningen av Nasjonalmuseet"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Statsministerens tale ved åpningen av Festspillene i Bergen"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/tema/transport-og-kommunikasjon/nasjonal-transportplan/ntp-2022-2033-i-arbeid-ny/nasjonal-transportplan-2022-2033---i-arbeid/alle-dokumenter-om-ntp-2022-2033/id2643251/");
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Meld. St. 20 (20202021) - Nasjonal transportplan 20222033"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Nasjonal transportplan 20222033: Beregninger og forutsetninger for leveranse til 15.10.20"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.LinkText("Nasjonal transportplan 2022-2033: Høring av transportvirksomhetenes svar på oppdrag fra Samferdselsdepartementet"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div/div"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("he");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/?term=he");
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("kroatsia");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/?term=kroatsia");
            try
            {
                Assert.AreEqual("Søket ditt gav 0 treff.", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Velg tidsperiode'])[2]/following::h2[1]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/tema/id208/");
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/?term=kroatsia");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Til toppen'])[1]/preceding::a[1]")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/no/sok/id86008/");
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div/p"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("mainsearch")).Click();
            driver.FindElement(By.Id("mainsearch")).Clear();
            driver.FindElement(By.Id("mainsearch")).SendKeys("jens");
            driver.FindElement(By.Id("searchPageNavigationSearchForm")).Submit();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div/p"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
            driver.FindElement(By.Id("mainsearch")).Click();
            driver.FindElement(By.Id("mainsearch")).Clear();
            driver.FindElement(By.Id("mainsearch")).SendKeys("jens og");
            driver.FindElement(By.Id("searchPageNavigationSearchForm")).Submit();
            driver.FindElement(By.Id("mainsearch")).Click();
            driver.FindElement(By.XPath("//form[@id='searchPageNavigationSearchForm']/fieldset/div")).Click();
            driver.FindElement(By.Id("mainsearch")).Click();
            driver.FindElement(By.Id("mainsearch")).Clear();
            driver.FindElement(By.Id("mainsearch")).SendKeys("jens jens");
            driver.FindElement(By.Id("searchPageNavigationSearchForm")).Submit();
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(By.XPath("//main[@id='mainContent']/div/div[2]/div/div/p"))) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }
      
        [TestMethod]
        public void TheRV71EngelskProdTest()
        {
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/id4/");
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("stoltenberg");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/search/id86008/?term=stoltenberg");
            driver.FindElement(By.LinkText("2")).Click();
            driver.FindElement(By.LinkText("Next")).Click();
            driver.FindElement(By.LinkText("Previous")).Click();
            try
            {
                Assert.AreEqual("Report to the Storting", driver.FindElement(By.XPath("//ul[@id='searchResultsListing']/li[10]/div/span[2]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("02/12/2014", driver.FindElement(By.XPath("//ul[@id='searchResultsListing']/li[2]/div/span")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Norwegian Official Report (NOU)", driver.FindElement(By.XPath("//ul[@id='searchResultsListing']/li[2]/div/span[2]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/dokumenter/prop.-102-ll-20112012/id680394/?q=stoltenberg");
            driver.FindElement(By.Id("megamenupanel_1_label")).Click();
            driver.FindElement(By.LinkText("Find document")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/find-document/id2000006/");
            try
            {
                Assert.AreEqual("Choose content type", driver.FindElement(By.Id("customSelectorTriggerdocumenttype")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Choose topic", driver.FindElement(By.Id("customSelectorTriggertopic")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Choose ministry", driver.FindElement(By.Id("customSelectorTriggerownerid")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Choose time period", driver.FindElement(By.Id("customSelectorTriggerfrom")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("megamenupanel_0_label")).Click();
            driver.FindElement(By.XPath("//div[@id='megamenupanel_0']/div/div/p/a")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/topics/id208/");
            driver.FindElement(By.Id("TopicSearch")).Click();
            driver.FindElement(By.Id("TopicSearch")).Clear();
            driver.FindElement(By.Id("TopicSearch")).SendKeys("maritime");
            try
            {
                Assert.AreEqual("The Maritime Industry", driver.FindElement(By.LinkText("The Maritime Industry")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/topics/id208/");
            driver.FindElement(By.Id("megamenupanel_3_label")).Click();
            driver.FindElement(By.LinkText("Ministry of Local Government and Regional Development")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/dep/kdd/id504/");
            driver.FindElement(By.XPath("//main[@id='mainContent']/div/div[5]/div[3]/p/a")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/find-document/id2000006/?ownerid=504");
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/dep/kdd/id504/");
            driver.FindElement(By.LinkText("News and Press releases")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/whatsnew/news-and-press-releases/id2006120/?ownerid=504");
            try
            {
                Assert.AreEqual("News and press releases", driver.FindElement(By.XPath("//main[@id='mainContent']/div/div/div/h1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("he");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='topnav-search-suggest']/ul/li[3]/a")).Click();

            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/topics/health-and-care/id917/");
            try
            {
                Assert.AreEqual("Health and care", driver.FindElement(By.XPath("//main[@id='mainContent']/div/div/div/h1")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.Id("quickSearch")).Click();
            driver.FindElement(By.Id("quickSearch")).Clear();
            driver.FindElement(By.Id("quickSearch")).SendKeys("he");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/search/id86008/?term=he");
            driver.Navigate().GoToUrl("https://www.regjeringen.no/en/search/id86008/?term=stoltenberg&page=2");
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
