using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABP.StockManagement.Customers;

public interface ICustomerAppService : IApplicationService
{
    Task<List<CustomerDto>> GetListAsync();
    Task<CustomerDto> GetAsync(Guid id);
    Task<CustomerDto> GetByCodeAsync(string code);
    Task<CustomerDto> CreateAsync(CustomerCreateDto input);
}
