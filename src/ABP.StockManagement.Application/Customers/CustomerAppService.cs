using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace ABP.StockManagement.Customers;

public class CustomerAppService : StockManagementAppService, ICustomerAppService
{
    public ICustomerRepository customerRepository { get; }
    public CustomerManager customerManager { get; }

    public CustomerAppService(ICustomerRepository customerRepository, CustomerManager customerManager)
    {
        this.customerRepository = customerRepository;
        this.customerManager = customerManager;
    }

    public async Task<CustomerDto> CreateAsync(CustomerCreateDto input)
    {
        try
        {
            var customer = await customerManager.CreateAsync(input.Code, input.Name);
            customer.SetName(input.Name);

            await customerRepository.InsertAsync(customer);

            return ObjectMapper.Map<Customer, CustomerDto>(customer);
        }
        catch (Exception ex)
        {

            throw;
        }
    }

    public async Task<CustomerDto> GetAsync(Guid id)
    {
        return ObjectMapper.Map<Customer, CustomerDto>(await customerRepository.GetAsync(id));
    }

    public async Task<CustomerDto> GetByCodeAsync(string code)
    {
        var customer = await customerRepository.FindByCodeAsync(code);

        if (customer is null)
            throw new UserFriendlyException($"{code} kodlu müşteri bulunamadı.");

        return ObjectMapper.Map<Customer, CustomerDto>(await customerRepository.FindByCodeAsync(code));
    }

    public async Task<List<CustomerDto>> GetListAsync()
    {
        var customers = await customerRepository.GetListAsync();
        return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(customers);
    }
}
