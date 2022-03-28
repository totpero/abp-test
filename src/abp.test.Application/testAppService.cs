using System;
using System.Collections.Generic;
using System.Text;
using abp.test.Localization;
using Volo.Abp.Application.Services;

namespace abp.test;

/* Inherit your application services from this class.
 */
public abstract class testAppService : ApplicationService
{
    protected testAppService()
    {
        LocalizationResource = typeof(testResource);
    }
}
