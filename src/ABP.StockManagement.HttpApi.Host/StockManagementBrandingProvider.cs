using Microsoft.Extensions.Localization;
using ABP.StockManagement.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABP.StockManagement;

[Dependency(ReplaceServices = true)]
public class StockManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StockManagementResource> _localizer;

    public StockManagementBrandingProvider(IStringLocalizer<StockManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
