using AbpSolution.Localization;
using Volo.Abp.Application.Services;

namespace AbpSolution;

/* Inherit your application services from this class.
 */
public abstract class AbpSolutionAppService : ApplicationService
{
    protected AbpSolutionAppService()
    {
        LocalizationResource = typeof(AbpSolutionResource);
    }
}
