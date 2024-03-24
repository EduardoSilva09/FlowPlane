using FlowPlane.Core.Entities;

namespace FlowPlane.Core.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
    }
}