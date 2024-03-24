using FlowPlane.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlowPlane.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
               .HasKey(u => u.Id);

            builder
                .HasMany(u => u.Activities)
                .WithOne()
                .HasForeignKey(a => a.IdClient)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}