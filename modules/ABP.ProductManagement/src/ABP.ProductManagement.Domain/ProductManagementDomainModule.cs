using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace ABP.ProductManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ProductManagementDomainSharedModule)
)]
public class ProductManagementDomainModule : AbpModule
{

}
