using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPlaywrightProject.PageObjects
{
    class loadDelayPageObjects
    {
        private IPage _page;
        private readonly ILocator _loadDelayLink;
        private readonly ILocator _button;


        public loadDelayPageObjects(IPage page)
        {
            _page = page;
            _loadDelayLink = _page.Locator("//a[contains(.,'Load Delay')]");
            _button = _page.Locator("//button[@class='btn btn-primary']");
        }

        public async Task clickLoadDealyLink()
        {
            await _loadDelayLink.ClickAsync();
        }
        public async Task<bool> validateButtonAppears() =>
            await _button.IsVisibleAsync();

    }
}
