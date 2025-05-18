using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpSolution.Data;
using Volo.Abp.DependencyInjection;

namespace AbpSolution.EntityFrameworkCore;

public class EntityFrameworkCoreAbpSolutionDbSchemaMigrator
    : IAbpSolutionDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpSolutionDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpSolutionDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpSolutionDbContext>()
            .Database
            .MigrateAsync();
    }
}
