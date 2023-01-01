using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPlaywrightProject.PageObjects
{
    class loginPageObjects
    {
        private IPage _page;
        private readonly ILocator _userNameField;
        private readonly ILocator _passWordField;
        private readonly ILocator _loginButton;
        private readonly ILocator _welcomeMessage;

        public loginPageObjects(IPage page)
        {
            _page = page;
            _userNameField = _page.Locator("//input[contains(@type,'text')]");
            _passWordField = _page.Locator("//input[contains(@type,'password')]");
            _loginButton = _page.Locator("//button[contains(@id,'login')]");
            _welcomeMessage = _page.Locator("//label[@class='text-success'][contains(.,'Welcome, Test!')]");
        }

        public async Task inputUserName()
        {
            await _userNameField.FillAsync("Test");
        }
        public async Task inputPassword()
        {
            await _passWordField.FillAsync("pwd");
        }
        public async Task clickLoginButton()
        {
            await _loginButton.ClickAsync();
        }
        public async Task <bool> validateWelcomeMessage() =>
            await _welcomeMessage.IsVisibleAsync();

    }
}
