using Kanini.LearningPortal.Domain.Entities;

namespace Kanini.LearningPortal.Application.Contracts.Persistence
{
    public interface IDepartmentsRepository
    {
        Task<List<Department>> GetAllDepartmentsAsync();
        Task<Department> GetDepartmentsByIdAsync(Guid departmentId);
        Task<int> AddDepartmentAsync(Department department);
        Task<int> UpdateDepartmentAsync(Department department);
        Task<int> DeleteDepartmentAsync(Guid departmentId);
    }
}
