using FlowPlane.Core.Entities;
using FlowPlane.Core.Repositories;

namespace FlowPlane.Infrastructure.Persistence.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly FlowPlaneDBContext _dbContext;
        public ActivityRepository(FlowPlaneDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddActivityAsync(Activity activity)
        {
            await _dbContext.Activities.AddAsync(activity);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteActivityAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Activity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Activity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateActivityAsync(Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}