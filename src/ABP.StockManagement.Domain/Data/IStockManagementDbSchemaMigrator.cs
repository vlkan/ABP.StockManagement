using System.Threading.Tasks;

namespace ABP.StockManagement.Data;

public interface IStockManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
