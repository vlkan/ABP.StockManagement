using ABP.StockManagement.Samples;
using Xunit;

namespace ABP.StockManagement.EntityFrameworkCore.Domains;

[Collection(StockManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StockManagementEntityFrameworkCoreTestModule>
{

}
