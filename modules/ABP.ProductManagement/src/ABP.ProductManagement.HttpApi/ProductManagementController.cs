using ABP.ProductManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP.ProductManagement;

public abstract class ProductManagementController : AbpControllerBase
{
    protected ProductManagementController()
    {
        LocalizationResource = typeof(ProductManagementResource);
    }
}
