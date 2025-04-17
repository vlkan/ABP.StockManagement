using ABP.StockManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABP.StockManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StockManagementEntityFrameworkCoreModule),
    typeof(StockManagementApplicationContractsModule)
)]
public class StockManagementDbMigratorModule : AbpModule
{
}
