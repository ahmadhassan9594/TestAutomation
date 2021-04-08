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

        var FormData = { Name: 'Ahmad', LastName: 'Hassan', MobileNo: '03346489459' }
        Object.keys(FormData);

        private IWebElement SelectForm => driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[2]/div"));
        private IWebElement Practiseform1 => driver.FindElement(By.XPath("//span[contains(text(),'Practice Form')]"));
        private IWebElement FirstName => driver.FindElement(By.XPath("//input[@id='firstName']"));
        private IWebElement LastName => driver.FindElement(By.XPath("//input[@id='lastName']"));
        private IWebElement Email => driver.FindElement(By.XPath("//input[@id='userEmail']"));
        private IWebElement Gender_Male => driver.FindElement(By.XPath("//label[contains(text(),'Male')]"));      
        private IWebElement MobileNo => driver.FindElement(By.XPath("//input[@id='userNumber']"));     
        private IWebElement Submit => driver.FindElement(By.XPath("//button[@id='submit']"));
        private IWebElement SubmissionFormTitle => driver.FindElement(By.XPath("//div[@id='example-modal-sizes-title-lg']"));


        internal void NavigatetoUrl()
        {
            var URL = "https://demoqa.com";
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);         
        }

        internal void SelectFormm()
        {
           SelectForm.Click();
        }
      
        internal void ClickPractiseForm()
        {
            Practiseform1.Click();            
        }

        internal void EnterFirstName(string name) 
        {
            FirstName.SendKeys(name);
        }

        internal void EnterLastNamee(string name)
        {
            LastName.SendKeys(name);

        }
        internal void EnterEmaill(string emailaddress)
        {
            Email.SendKeys(emailaddress);
            
        }
        internal void SelectGenderMale()
        {
            Gender_Male.Click();
        }

        internal void EnterMobileNumber(string number)
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
