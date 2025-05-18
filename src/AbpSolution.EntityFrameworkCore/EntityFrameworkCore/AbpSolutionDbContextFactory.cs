using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpSolution.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpSolutionDbContextFactory : IDesignTimeDbContextFactory<AbpSolutionDbContext>
{
    public AbpSolutionDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpSolutionEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpSolutionDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpSolutionDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpSolution.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
