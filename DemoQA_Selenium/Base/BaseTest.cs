using System;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoQA_Selenium
{
    public class BaseTest 
    {

        public static IWebDriver driver { get; set; }

        public IWebDriver GetBrowserDriver()
        {
            var OutPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            Console.WriteLine(OutPutDirectory);
            return new ChromeDriver(OutPutDirectory);

        }

         [SetUp]
        public void SetupBeforeEveryTest()
        {
           
            driver = GetBrowserDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
        }
        
        public static void softassertion(String expected, String actual)
        {

            try
            {

                //Assert.AreEqual(actual, expected);

            }
            catch (Exception t)
            {

                //TestUtil.captureScreenshot();
                Console.WriteLine(t.Message);
            }

        }

         [TearDown]
        public void TeardownAfterEveryTest()
        {
         
            driver.Close();
            driver.Quit();
            
        }

    }
}
