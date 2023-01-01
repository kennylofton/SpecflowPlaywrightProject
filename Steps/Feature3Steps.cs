using SpecflowPlaywrightProject.Drivers;
using SpecflowPlaywrightProject.PageObjects;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowPlaywrightProject.Steps
{
    [Binding]
    public class Feature3Steps
    {
        private readonly Driver _driver;
        private readonly clientSideDelayPageObjects _clientSideDelayPageObjects;

        public Feature3Steps (Driver driver)
        {
            _driver = driver;
            _clientSideDelayPageObjects = new clientSideDelayPageObjects(_driver.Page);
        }

        [Given(@"I am on the app")]
        public async Task GivenIAmOnTheApp()
        {
            await _driver.Page.GotoAsync("http://uitestingplayground.com/clientdelay");
        }
        
        [When(@"I click the button trigger")]
        public async Task WhenIClickTheButtonTrigger()
        {
            await _clientSideDelayPageObjects.clickTriggerButton();
        }
        
        [Then(@"I should be presented with the label text")]
        public async Task ThenIShouldBePresentedWithTheLabelText()
        {
            await _clientSideDelayPageObjects.validateTextLabel();
        }
    }
}
