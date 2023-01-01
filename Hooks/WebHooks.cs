using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace SpecflowPlaywrightProject.Hooks
{
    [Binding]
    public class WebHooks
    {
    }
}
