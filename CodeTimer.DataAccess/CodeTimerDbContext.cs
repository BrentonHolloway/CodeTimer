using CodeTimer.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeTimer.DataAccess;

public class CodeTimerDbContext : DbContext
{
    public virtual DbSet<Session> Sessions { get; set; }

    public CodeTimerDbContext(DbContextOptions<CodeTimerDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CodeTimerDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
