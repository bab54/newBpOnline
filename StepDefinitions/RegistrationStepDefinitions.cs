using NewBpbonline.Hooks;
using OpenQA.Selenium;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace NewBpbonline.StepDefinitions
{
    [Binding]
    public  class RegistrationStepDefinitions 
    {
        public static  IWebDriver driver;
        BaseText baseText = new BaseText();
        
        [Given(@"that a user navigates to bpbonline website")]
        public void GivenThatAUserNavigatesToBpbonlineWebsite()
        {
            baseText.goToUrl();
        }

        [Given(@"the user cliks on my account")]
        public void GivenTheUserCliksOnMyAccount()
        {
           
        }

        [Given(@"the user clicks on continue")]
        public void GivenTheUserClicksOnContinue()
        {
           
        }

        [Given(@"the user clicks on gender")]
        public void GivenTheUserClicksOnGender()
        {
            
        }

        [Given(@"the user enters first name ""([^""]*)""")]
        public void GivenTheUserEntersFirstName(string tuns)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters last name  ""([^""]*)""")]
        public void GivenTheUserEntersLastName(string ase)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters date of birth ""([^""]*)""")]
        public void GivenTheUserEntersDateOfBirth(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters email address ""([^""]*)""")]
        public void GivenTheUserEntersEmailAddress(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user emters company name ""([^""]*)""")]
        public void GivenTheUserEmtersCompanyName(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters street address ""([^""]*)""")]
        public void GivenTheUserEntersStreetAddress(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters suburb ""([^""]*)""")]
        public void GivenTheUserEntersSuburb(string essex)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters post code ""([^""]*)""")]
        public void GivenTheUserEntersPostCode(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user eners city  ""([^""]*)""")]
        public void GivenTheUserEnersCity(string surrey)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters state ""([^""]*)""")]
        public void GivenTheUserEntersState(string london)
        {
            throw new PendingStepException();
        }

        [Given(@"the user select country united kingdom")]
        public void GivenTheUserSelectCountryUnitedKingdom()
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters telephone no ""([^""]*)""")]
        public void GivenTheUserEntersTelephoneNo(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters fax number ""([^""]*)""")]
        public void GivenTheUserEntersFaxNumber(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the user clicks newsleter")]
        public void GivenTheUserClicksNewsleter()
        {
            throw new PendingStepException();
        }

        [Given(@"the user enters password ""([^""]*)""")]
        public void GivenTheUserEntersPassword(string qwerty)
        {
            throw new PendingStepException();
        }

        [When(@"the user enters comfirm password ""([^""]*)""")]
        public void WhenTheUserEntersComfirmPassword(string qwerty)
        {
            throw new PendingStepException();
        }

        [When(@"I CLICK ON THE CONTINUE BUTTON")]
        public void WhenICLICKONTHECONTINUEBUTTON()
        {
            throw new PendingStepException();
        }

        [Then(@"the user is registrated with the following message ""([^""]*)""")]
        public void ThenTheUserIsRegistratedWithTheFollowingMessage(string p0)
        {
            throw new PendingStepException();
        }
    }
}
