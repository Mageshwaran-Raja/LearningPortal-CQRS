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

        public Task<int> DeleteRoleAsync(int roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Role>> GetAllRolesAsync()
        {
            return await _learningPortalDBContext.Roles.ToListAsync();
        }

        public async Task<Role> GetRoleByIdAsync(int roleId)
        {
            return await _learningPortalDBContext.Roles.FirstAsync(x => x.RoleId == roleId);
        }

        public Task<int> UpdateRoleAsync(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
