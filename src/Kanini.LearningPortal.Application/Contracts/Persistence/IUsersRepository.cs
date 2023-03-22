using Kanini.LearningPortal.Domain.Entities;

namespace Kanini.LearningPortal.Application.Contracts.Persistence
{
    public interface IUsersRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByMailIdAsync(string mailId);
        Task<int> AddUser(User user);
        Task<int> UpdateUser(User user);
        Task<int> DeleteUser(string mailId);
    }
}
