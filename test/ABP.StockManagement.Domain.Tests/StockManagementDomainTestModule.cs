using Volo.Abp.Modularity;

namespace ABP.StockManagement;

[DependsOn(
    typeof(StockManagementDomainModule),
    typeof(StockManagementTestBaseModule)
)]
public class StockManagementDomainTestModule : AbpModule
{

}
