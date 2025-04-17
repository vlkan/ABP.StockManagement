using ABP.ProductManagement.Localization;
using Volo.Abp.Application.Services;

namespace ABP.ProductManagement;

public abstract class ProductManagementAppService : ApplicationService
{
    protected ProductManagementAppService()
    {
        LocalizationResource = typeof(ProductManagementResource);
        ObjectMapperContext = typeof(ProductManagementApplicationModule);
    }
}
