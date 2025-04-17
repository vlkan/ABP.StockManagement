using ABP.StockManagement.Localization;
using Volo.Abp.Application.Services;

namespace ABP.StockManagement;

/* Inherit your application services from this class.
 */
public abstract class StockManagementAppService : ApplicationService
{
    protected StockManagementAppService()
    {
        LocalizationResource = typeof(StockManagementResource);
    }
}
