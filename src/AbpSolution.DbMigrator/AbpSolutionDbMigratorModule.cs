using AbpSolution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpSolution.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpSolutionEntityFrameworkCoreModule),
    typeof(AbpSolutionApplicationContractsModule)
)]
public class AbpSolutionDbMigratorModule : AbpModule
{
}
