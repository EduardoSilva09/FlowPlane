using FlowPlane.Core.Entities;

namespace FlowPlane.Core.Repositories
{
    public interface IActivityRepository
    {
        Task<List<Activity>> GetAllAsync();
        Task<Activity> GetByIdAsync(int id);
        Task AddActivityAsync(Activity activity);
        Task UpdateActivityAsync(Activity activity);
        Task DeleteActivityAsync(int id);
        Task SaveChangesAsync();
    }
}