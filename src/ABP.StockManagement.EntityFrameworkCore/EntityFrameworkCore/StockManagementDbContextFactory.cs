using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABP.StockManagement.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class StockManagementDbContextFactory : IDesignTimeDbContextFactory<StockManagementDbContext>
{
    public StockManagementDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        StockManagementEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<StockManagementDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new StockManagementDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ABP.StockManagement.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
