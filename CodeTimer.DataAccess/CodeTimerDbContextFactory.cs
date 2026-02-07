using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CodeTimer.DataAccess;

public class CodeTimerDbContextFactory : IDesignTimeDbContextFactory<CodeTimerDbContext>
{
    public CodeTimerDbContext CreateDbContext(string[] args)
    {
        // Point to the UI project's directory (adjust relative path if needed)
        var basePath = Directory.GetCurrentDirectory();
        if (basePath.Contains("CodeTimer.DataAccess", StringComparison.Ordinal))
        {
            // If running from DataAccess folder → go up to solution root / UI folder
            basePath = Path.Combine(basePath, "..", "CodeTimer.UI");
        }

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: true)
            .AddJsonFile("appsettings.Development.json", optional: true)
            .Build();

        var connectionString = configuration.GetConnectionString("Default")
            ?? "Data Source=codetimer.db";  // fallback

        var optionsBuilder = new DbContextOptionsBuilder<CodeTimerDbContext>();
        optionsBuilder.UseSqlite(connectionString);

        return new CodeTimerDbContext(optionsBuilder.Options);
    }
}