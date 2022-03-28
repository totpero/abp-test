using System.Threading.Tasks;

namespace abp.test.Data;

public interface ItestDbSchemaMigrator
{
    Task MigrateAsync();
}
