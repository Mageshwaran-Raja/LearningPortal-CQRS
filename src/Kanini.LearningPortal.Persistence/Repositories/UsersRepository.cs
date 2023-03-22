using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Domain.Entities;
using Kanini.LearningPortal.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Kanini.LearningPortal.Persistence.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        protected readonly LearningPortalDBContext _learningPortalDBContext;

        public UsersRepository(LearningPortalDBContext learningPortalDBContext)
        {
            _learningPortalDBContext = learningPortalDBContext;
        }

        public async Task<int> AddUser(User user)
        {
            
            await _learningPortalDBContext.Users.AddAsync(user);
            return await _learningPortalDBContext.SaveChangesAsync();
        }

        public Task<int> DeleteUser(string mailId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _learningPortalDBContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByMailIdAsync(string mailId)
        {
            return await _learningPortalDBContext.Users.FirstAsync(x => x.MailId == mailId);
        }

        public Task<int> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
