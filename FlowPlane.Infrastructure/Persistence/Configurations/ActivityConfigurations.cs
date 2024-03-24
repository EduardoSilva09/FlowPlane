using FlowPlane.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FlowPlane.Infrastructure.Persistence.Configurations
{
    public class ActivityConfigurations : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");

            builder.HasKey(p => p.Id);
            builder.Property(a => a.Title)
              .IsRequired()
              .HasMaxLength(255);

            builder
                .Property(a => a.Description)
                .HasMaxLength(500);

            builder
                .Property(a => a.RepeatPeriod)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(a => a.DaysOfWeek)
              .IsRequired()
              .HasConversion(
                  v => string.Join(',', v.Select(d => d.ToString())),
                  v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => Enum.Parse<DayOfWeek>(s)).ToArray()
              );
        }
    }
}