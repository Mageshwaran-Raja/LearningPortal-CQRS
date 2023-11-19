using Kanini.LearningPortal.Persistence;

namespace Kanini.LearningPortal.Application.Contracts.Persistence
{
    public interface IRolesRepository
    {
        Task<List<Role>> GetAllRolesAsync();
        Task<Role> GetRoleByIdAsync(int roleId);
        Task<int> AddRoleAsync(Role role);
        Task<int> UpdateRoleAsync(Role role);
        Task<int> DeleteRoleAsync(int roleId);
    }
}
