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
            pf.GoTo();                                     //Navigating to URL
            pf.SelectingForm();                            //Navigating to Forms
            pf.ClickPractiseForm();                        //Clicking Practise Form
            pf.FirstNamee("Ahmad");                        //Entering First Name
            pf.LastNamee("Hassan");                        //Entering Last Name
            pf.SelectMale();                               //Selecting Gender as Male
            pf.MobileNumber("03346489594");                //Entering Mobile No
            Thread.Sleep(10000);
            pf.SubmitForm();                                //Submitting the Form


            //Validating

            string ActualTiltle = pf.ConfirmSubmission();                               //Getting the title of the Form after clicking Submit button
            string ExpectedTitle = "Thanks for submitting the form";

            Assert.AreEqual(ExpectedTitle, ActualTiltle);                                   

        }


        [Test]
        public void SecondCase()
        {
            PractiseForm pf = new PractiseForm(driver);
            pf.GoTo();                                                                              //Navigating to URL
            pf.SelectingForm();                                                                     //Clicking on Forms
            pf.ClickPractiseForm();                                                                 //Clicking on Practise Form
            Thread.Sleep(4000);
            string FieldColorbeforSubmit = pf.MandatoryCheckFirstNameBeforeSubmit();
            string Field2 = pf.MandatoryCheckLastNameBeforeSubmit();
            string Field3 = pf.MandatoryCheckGenderBeforeSubmit();

            pf.PageScrollDown();
            pf.SubmitForm();
            
            string FieldColorAfterSubmit = pf.MandatoryCheckFirstNameAfterSubmit();
            string Field4 = pf.MandatoryCheckLastNameAfterSubmit();
            string Field5 = pf.MandatoryCheckGenderAfterSubmit();

            Assert.Multiple(() =>
            {
                Assert.AreNotEqual(FieldColorbeforSubmit, FieldColorAfterSubmit, "First Assert");
                Assert.AreNotEqual(Field2, Field4, "Second Assert");
                Assert.AreNotEqual(Field3, Field5, "Asserts are not equal");
            });



          


        }
    }
}
