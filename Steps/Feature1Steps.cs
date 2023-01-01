using System;
using TechTalk.SpecFlow;
using SpecflowPlaywrightProject.PageObjects;
using SpecflowPlaywrightProject.Drivers;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpecflowPlaywrightProject.Steps
{
    [Binding]
    public class Feature1Steps
    {
        private readonly Driver _driver;
        private readonly textInputPageObjects _textInputPageObjects;
        public Feature1Steps(Driver driver)
        {
            _driver = driver;
            _textInputPageObjects = new textInputPageObjects(_driver.Page);
        }

        [Given(@"I navigate to the application")]
        public async Task GivenINavigateToTheApplicationAsync()
        {
            await _driver.Page.GotoAsync("http://uitestingplayground.com/textinput");
        }
        
        [Given(@"I input a name in the text field")]
        public async Task GivenIInputANameInTheTextField()
        {
            await _textInputPageObjects.inputText();
        }
        
        [When(@"I click the button")]
        public async Task WhenIClickTheButton()
        {
            await _textInputPageObjects.clickButton();
        }
        
        [Then(@"the button value should change")]
        public async Task ThenTheButtonValueShouldChange()
        {
            var textExists = await _textInputPageObjects.validateButtonValue();
            Assert.IsTrue(textExists);
        }
    }
}
