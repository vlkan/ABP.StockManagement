using Volo.Abp.Modularity;

namespace ABP.StockManagement;

public abstract class StockManagementApplicationTestBase<TStartupModule> : StockManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
