using ABP.StockManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ABP.StockManagement.Customers;

public class EfCoreCustomerRepository : EfCoreRepository<StockManagementDbContext, Customer, Guid>, ICustomerRepository
{
    public EfCoreCustomerRepository(IDbContextProvider<StockManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<Customer?> FindByCodeAsync(string code, CancellationToken cancellationToken)
    {
        IQueryable<Customer?> dbSet = await GetQueryableAsync();

        return await dbSet.FirstOrDefaultAsync(x => x.Code == code, GetCancellationToken(cancellationToken));
    }
}
