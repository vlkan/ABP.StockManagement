using ABP.StockManagement.Samples;
using Xunit;

namespace ABP.StockManagement.EntityFrameworkCore.Applications;

[Collection(StockManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StockManagementEntityFrameworkCoreTestModule>
{

}
