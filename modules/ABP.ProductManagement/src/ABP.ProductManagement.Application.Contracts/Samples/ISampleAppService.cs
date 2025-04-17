using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ABP.ProductManagement.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
