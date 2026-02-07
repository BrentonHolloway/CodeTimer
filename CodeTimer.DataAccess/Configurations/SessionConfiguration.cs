using CodeTimer.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeTimer.DataAccess.Configurations;

public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.ToTable("Sessions");

        builder.Property(s => s.StartDateTime)
               .IsRequired();

        builder.HasMany(s => s.Tags)
            .WithMany(t => t.Sessions)
            .UsingEntity(j => j.ToTable("SessionTags"));
    }
}
