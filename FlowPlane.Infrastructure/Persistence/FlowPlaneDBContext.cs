using System.Reflection;
using FlowPlane.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FlowPlane.Infrastructure.Persistence
{
    public class FlowPlaneDBContext : DbContext
    {
        public FlowPlaneDBContext(DbContextOptions<FlowPlaneDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}