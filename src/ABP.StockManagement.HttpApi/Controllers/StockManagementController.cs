using ABP.StockManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP.StockManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StockManagementController : AbpControllerBase
{
    protected StockManagementController()
    {
        LocalizationResource = typeof(StockManagementResource);
    }
}
