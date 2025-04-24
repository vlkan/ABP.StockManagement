using ABP.StockManagement.Customers;
using AutoMapper;

namespace ABP.StockManagement;

public class StockManagementApplicationAutoMapperProfile : Profile
{
    public StockManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Customer, CustomerDto>();
    }
}
