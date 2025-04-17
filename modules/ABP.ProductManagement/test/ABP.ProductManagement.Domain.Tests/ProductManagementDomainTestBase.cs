using Volo.Abp.Modularity;

namespace ABP.ProductManagement;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class ProductManagementDomainTestBase<TStartupModule> : ProductManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
