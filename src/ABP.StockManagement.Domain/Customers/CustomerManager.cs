using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace ABP.StockManagement.Customers;

public class CustomerManager : DomainService
{
    public ICustomerRepository CustomerRepository { get; }

    public CustomerManager(ICustomerRepository customerRepository)
    {
        CustomerRepository = customerRepository;
    }

    public async Task<Customer> CreateAsync(string code, string name)
    {
        var existingCustomer = await CustomerRepository.FindByCodeAsync(code);

        if (existingCustomer is not null)
            throw new BusinessException(StockManagementDomainErrorCodes.CustomerCodeAlreadyExists).WithData("CustomerCode", code);

        return new Customer(GuidGenerator.Create(), code, name);
    }
}
