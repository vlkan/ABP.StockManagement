using Volo.Abp.Modularity;

namespace ABP.StockManagement;

[DependsOn(
    typeof(StockManagementApplicationModule),
    typeof(StockManagementDomainTestModule)
)]
public class StockManagementApplicationTestModule : AbpModule
{

}
