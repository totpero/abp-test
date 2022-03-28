using abp.test.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abp.test.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(testEntityFrameworkCoreModule),
    typeof(testApplicationContractsModule)
    )]
public class testDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
