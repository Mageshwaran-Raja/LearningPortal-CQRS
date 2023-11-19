using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Domain.Entities;
using Kanini.LearningPortal.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Kanini.LearningPortal.Persistence.Repositories
{
    public class DepartmentsRepository : IDepartmentsRepository
    {
        protected readonly LearningPortalDBContext _learningPortalDBContext;

        public DepartmentsRepository(LearningPortalDBContext learningPortalDBContext)
        {
            _learningPortalDBContext = learningPortalDBContext;
        }

        public Task<int> AddDepartmentAsync(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteDepartmentAsync(Guid departmentId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await _learningPortalDBContext.Departments.ToListAsync();
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
