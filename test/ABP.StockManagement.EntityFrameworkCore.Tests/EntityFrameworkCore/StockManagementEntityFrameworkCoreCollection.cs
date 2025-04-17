using Xunit;

namespace ABP.StockManagement.EntityFrameworkCore;

[CollectionDefinition(StockManagementTestConsts.CollectionDefinitionName)]
public class StockManagementEntityFrameworkCoreCollection : ICollectionFixture<StockManagementEntityFrameworkCoreFixture>
{

}
