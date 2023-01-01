using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPlaywrightProject.PageObjects
{
    class clientSideDelayPageObjects
    {
        private IPage _page;
        private readonly ILocator _triggerButton;
        private readonly ILocator _textLabel;

        public clientSideDelayPageObjects(IPage page)
        {
            _page = page;
            _triggerButton = _page.Locator("//button[contains(@id,'ajaxButton')]");
            _textLabel = _page.Locator("//p[contains(.,'Data calculated on the client side.')]");
        }

        public async Task clickTriggerButton()
        {
            await _triggerButton.ClickAsync();
        }

        public async Task<bool> validateTextLabel() =>
            await _textLabel.IsVisibleAsync();
    }
}
