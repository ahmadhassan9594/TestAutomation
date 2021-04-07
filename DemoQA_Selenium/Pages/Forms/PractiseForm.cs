using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace POMFrameWork
{

    class PractiseForm
    {
        public PractiseForm(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebDriver driver { get; set; }

        private IWebElement SelectForm => driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[2]/div"));

        private IWebElement Practiseform1 => driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]"));


        private IWebElement FirstName => driver.FindElement(By.XPath("//input[@id='firstName']"));
        private IWebElement LastName => driver.FindElement(By.XPath("//input[@id='lastName']"));
        private IWebElement Email => driver.FindElement(By.XPath("//input[@id='userEmail']"));
        private IWebElement Gender_Male => driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));
        private IWebElement Gender_Female => driver.FindElement(By.XPath("//label[contains(text(),'Female')]"));
        private IWebElement Gender_other => driver.FindElement(By.XPath("//label[contains(text(),'Other')]"));
        private IWebElement MobileNo => driver.FindElement(By.XPath("//input[@id='userNumber']"));
        private IWebElement DOB => driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
        private IWebElement Subjects => driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[1]/form[1]/div[6]/div[2]/div[1]/div[1]/div[1]"));
        private IWebElement Hobby_sports => driver.FindElement(By.XPath("//label[contains(text(),'Sports')]"));
        private IWebElement Hobby_reading => driver.FindElement(By.XPath("//label[contains(text(),'Reading')]"));
        private IWebElement Hobby_music => driver.FindElement(By.XPath("//label[contains(text(),'Music')]"));
        private IWebElement Address => driver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
        private IWebElement State => driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]"));
        private IWebElement City => driver.FindElement(By.XPath("//body/div[@id='app']/div[1]/div[1]/div[2]/div[2]/div[1]/form[1]/div[10]/div[3]/div[1]/div[1]/div[1]"));

        private IWebElement Submit => driver.FindElement(By.XPath("//button[@id='submit']"));
        private IWebElement SubmissionFormTitle => driver.FindElement(By.XPath("//div[@id='example-modal-sizes-title-lg']"));


        internal void GoTo()
        {
            var URL = "https://demoqa.com";
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
           

        }

        internal void SelectingForm()
        {
            //driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[2]/div")).Click();
           SelectForm.Click();

            // Actions action = new Actions(driver);

            //action.MoveToElement(SelectForm).Click().Perform();
            //Thread.Sleep(3000);
            //Console.WriteLine("Ahmad");

        }
      

        internal void ClickPractiseForm()
        {
            Practiseform1.Click();


        }

        internal void FirstNamee(string name) 
        {
            FirstName.SendKeys(name);
        }

        internal void LastNamee(string name)
        {
            LastName.SendKeys(name);

        }
        internal void Emaill(string emailaddress)
        {
            Email.SendKeys(emailaddress);
            
        }
        internal void SelectMale()
        {
            Gender_Male.Click();
        }

        internal void MobileNumber(string number)
        {
            MobileNo.SendKeys(number);
           

        }
        internal void PageScrollDown()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,600);");
            
        }
        internal void SubmitForm()
        {
                       
            Submit.Click();
            
        }

        internal string ConfirmSubmission() 
        {
            string title = SubmissionFormTitle.Text;

            return title;

        }

        internal string MandatoryCheckFirstNameBeforeSubmit()
        {
            string value = FirstName.GetCssValue("color");
            return value;


        }

        internal string MandatoryCheckFirstNameAfterSubmit()
        {
            string value = FirstName.GetCssValue("background-color");
            return value;


        }
        internal string MandatoryCheckLastNameBeforeSubmit()
        {
            string value = LastName.GetCssValue("color");
            return value;


        }
        internal string MandatoryCheckGenderBeforeSubmit()
        {
            string value = Gender_Male.GetCssValue("color");
            return value;

        }

        internal string MandatoryCheckLastNameAfterSubmit()
        {
            string value = LastName.GetCssValue("background-color");
            return value;


        }
        internal string MandatoryCheckGenderAfterSubmit()
        {
            string value = Gender_Male.GetCssValue("background-color");
            return value;


        }





    }
}
