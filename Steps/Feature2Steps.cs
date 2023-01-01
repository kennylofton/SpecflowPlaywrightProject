using SpecflowPlaywrightProject.Drivers;
using SpecflowPlaywrightProject.PageObjects;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowPlaywrightProject.Steps
{
    [Binding]
    public class Feature2Steps
    {
        private readonly Driver _driver;
        private readonly loginPageObjects _loginPageObjects;

        public Feature2Steps(Driver driver)
        {
            _driver = driver;
            _loginPageObjects = new loginPageObjects(_driver.Page);
        }

        [Given(@"I navigate to the app")]
        public async Task GivenINavigateToTheApp()
        {
            await _driver.Page.GotoAsync("http://uitestingplayground.com/sampleapp");
        }
        
        [Given(@"I input a username")]
        public async Task GivenIInputAUsername()
        {
            await _loginPageObjects.inputUserName();
        }
        
        [Given(@"I input the correct password")]
        public async Task GivenIInputTheCorrectPassword()
        {
            await _loginPageObjects.inputPassword();
        }
        
        [When(@"I select the Login button")]
        public async Task WhenISelectTheLoginButton()
        {
            await _loginPageObjects.clickLoginButton();
        }
        
        [Then(@"I should be presented with the welcome message")]
        public async Task ThenIShouldBePresentedWithTheWelcomeMessage()
        {
            await _loginPageObjects.validateWelcomeMessage();
        }
    }
}
