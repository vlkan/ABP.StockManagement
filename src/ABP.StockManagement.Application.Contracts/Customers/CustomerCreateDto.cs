using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;

namespace ABP.StockManagement.Customers;

public class CustomerCreateDto
{
    [Required]
    [DynamicStringLength(typeof(CustomerConsts), nameof(CustomerConsts.MaxNameLength), nameof(CustomerConsts.MinNameLength))]
    public string Code { get; set; } = null!;
    public string? Name { get; set; }
}
