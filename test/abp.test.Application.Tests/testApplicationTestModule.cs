using Volo.Abp.Modularity;

namespace abp.test;

[DependsOn(
    typeof(testApplicationModule),
    typeof(testDomainTestModule)
    )]
public class testApplicationTestModule : AbpModule
{

}
