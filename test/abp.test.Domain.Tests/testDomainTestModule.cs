using abp.test.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abp.test;

[DependsOn(
    typeof(testEntityFrameworkCoreTestModule)
    )]
public class testDomainTestModule : AbpModule
{

}
