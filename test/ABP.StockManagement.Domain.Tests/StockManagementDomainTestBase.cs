using Volo.Abp.Modularity;

namespace ABP.StockManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class StockManagementDomainTestBase<TStartupModule> : StockManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
