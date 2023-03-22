using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Kanini.LearningPortal.Persistence.Repositories
{
    public class RolesRepository : IRolesRepository
    {
        protected readonly LearningPortalDBContext _learningPortalDBContext;

        public RolesRepository(LearningPortalDBContext learningPortalDBContext)
        {
            _learningPortalDBContext = learningPortalDBContext;
        }

        public Task<int> AddRoleAsync(Role role)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRoleAsync(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Role>> GetAllRolesAsync()
        {
            return await _learningPortalDBContext.Roles.ToListAsync();
        }

        public Task<Role> GetRoleByIdAsync(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateRoleAsync(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
