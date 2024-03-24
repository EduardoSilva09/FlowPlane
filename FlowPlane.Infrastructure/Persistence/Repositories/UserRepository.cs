using FlowPlane.Core.Entities;
using FlowPlane.Core.Repositories;

namespace FlowPlane.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FlowPlaneDBContext _dbContext;
        public UserRepository(FlowPlaneDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
    }
}