using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpecflowPlaywrightProject.PageObjects
{
    class textInputPageObjects
    {
        private IPage _page;
        private readonly ILocator _textField;
        private readonly ILocator _button;
        private readonly ILocator _buttonText;

        public textInputPageObjects(IPage page)
        {
            _page = page;
            _textField = _page.Locator("//input[@id='newButtonName']");
            _button = _page.Locator("//button[@id='updatingButton']");
            _buttonText = _page.Locator("//button[@class='btn btn-primary'][contains(.,'Test')]");
        }

        public async Task inputText() => await _textField.FillAsync("Test");
        public async Task clickButton() => await _button.ClickAsync();

        public async Task<bool> validateButtonValue() => await _buttonText.IsVisibleAsync();
    }
}
