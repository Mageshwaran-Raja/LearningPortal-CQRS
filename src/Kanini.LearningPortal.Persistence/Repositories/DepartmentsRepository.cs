using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Domain.Entities;

namespace Kanini.LearningPortal.Persistence.Repositories
{
    public class DepartmentsRepository : IDepartmentsRepository
    {
        public Task<int> AddDepartmentAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteDepartmentAsync(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetAllDepartmentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Department> GetDepartmentsByIdAsync(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateDepartmentAsync(Department department)
        {
            throw new NotImplementedException();
        }
    }
}
