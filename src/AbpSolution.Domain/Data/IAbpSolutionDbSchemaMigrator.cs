using System.Threading.Tasks;

namespace AbpSolution.Data;

public interface IAbpSolutionDbSchemaMigrator
{
    Task MigrateAsync();
}
