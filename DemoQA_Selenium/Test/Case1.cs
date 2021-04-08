using System;
using System.Collections.Generic;
using System.Text;
using POMFrameWork;
using NUnit;
using NUnit.Framework;
using System.Threading;

namespace DemoQA_Selenium.Test
{

    class Case1 : BaseTest
    {

        [Test]

        public void FirstCase()
        {
            PractiseForm pf = new PractiseForm(driver);
            pf.NavigatetoUrl();                          //Navigating to URL
            pf.SelectFormm();                           //Navigating to Forms
            pf.ClickPractiseForm();                     //Clicking Practise Form
            pf.EnterFirstName("Ahmad");                 //Entering First Name
            pf.EnterLastNamee("Hassan");                //Entering Last Name
            pf.SelectGenderMale();                      //Selecting Gender as Male
            pf.EnterMobileNumber("0334648959");         //Entering Mobile No
            
            Thread.Sleep(5000);
            pf.PageScrollDown();
            pf.SubmitForm();                             //Submitting the Form
            
            //Validating

            string ActualTiltleofSubmissionForm = pf.ConfirmSubmission();                               //Getting the title of the Form after clicking Submit button
            string ExpectedTitleofSubmissionForm = "Thanks for submitting the form";

            Assert.AreEqual(ExpectedTitleofSubmissionForm, ActualTiltleofSubmissionForm,"The form failed to submit.");                                   

        }


        [Test]
        public void SecondCase()
        {
            PractiseForm pf = new PractiseForm(driver);
            pf.NavigatetoUrl();                                                                   //Navigating to URL
            pf.SelectFormm();                                                                     //Clicking on Forms
            pf.ClickPractiseForm();                                                               //Clicking on Practise Form
            Thread.Sleep(4000);
            string FirstNameFieldColorbeforeSubmit = pf.MandatoryCheckFirstNameBeforeSubmit();
            string LastNameFieldColorbeforeSubmit = pf.MandatoryCheckLastNameBeforeSubmit();
            string GenderFieldColorbeforeSubmit = pf.MandatoryCheckGenderBeforeSubmit();

            pf.PageScrollDown();
            pf.SubmitForm();
            
            string FirstNameFieldColorafterSubmit = pf.MandatoryCheckFirstNameAfterSubmit();
            string LastNameFieldColorafterSubmit = pf.MandatoryCheckLastNameAfterSubmit();
            string GenderFieldColorafterSubmit = pf.MandatoryCheckGenderAfterSubmit();

            Assert.Multiple(() =>
            {
                Assert.AreNotEqual(FirstNameFieldColorbeforeSubmit, FirstNameFieldColorafterSubmit, "Mandatory Check is missing on First Name field");
                Assert.AreNotEqual(LastNameFieldColorbeforeSubmit, LastNameFieldColorafterSubmit, "Mandatory Check is missing on Last name field.");
                Assert.AreNotEqual(GenderFieldColorbeforeSubmit, GenderFieldColorafterSubmit, "Mandatory Check is missing on Gender field.");
            });        
        }
    }
}
