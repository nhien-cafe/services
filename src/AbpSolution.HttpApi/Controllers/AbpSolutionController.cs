using AbpSolution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSolution.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpSolutionController : AbpControllerBase
{
    protected AbpSolutionController()
    {
        LocalizationResource = typeof(AbpSolutionResource);
    }
}
