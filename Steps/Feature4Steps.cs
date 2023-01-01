using SpecflowPlaywrightProject.Drivers;
using SpecflowPlaywrightProject.PageObjects;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowPlaywrightProject.Steps
{
    [Binding]
    public class Feature4Steps
    {

        private readonly Driver _driver;
        private readonly loadDelayPageObjects _loadDelayPageObjects;

        public Feature4Steps(Driver driver)
        {
            _driver = driver;
            _loadDelayPageObjects = new loadDelayPageObjects(_driver.Page);
        }

        [Given(@"I am on the website")]
        public async Task GivenIAmOnTheWebsite()
        {
            await _driver.Page.GotoAsync("http://uitestingplayground.com/");
        }

        [Given(@"I select the load delay option")]
        public async Task GivenISelectTheLoadDelayOption()
        {
            await _loadDelayPageObjects.clickLoadDealyLink();
        }
        
        [Then(@"the page should load up with the correct button")]
        public async Task ThenThePageShouldLoadUpWithTheCorrectButton()
        {
            await _loadDelayPageObjects.validateButtonAppears();
        }
    }
}
