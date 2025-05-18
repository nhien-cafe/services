using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpSolution.Data;

/* This is used if database provider does't define
 * IAbpSolutionDbSchemaMigrator implementation.
 */
public class NullAbpSolutionDbSchemaMigrator : IAbpSolutionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
