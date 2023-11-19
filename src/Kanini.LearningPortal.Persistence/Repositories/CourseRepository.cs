using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Domain.Entities;
using Kanini.LearningPortal.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Kanini.LearningPortal.Persistence.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        protected readonly LearningPortalDBContext _learningPortalDBContext;

        public CourseRepository(LearningPortalDBContext learningPortalDBContext)
        {
            _learningPortalDBContext = learningPortalDBContext;
        }

        public async Task<int> AddCourseAsync(Course course)
        {
            await _learningPortalDBContext.Courses.AddAsync(course);    
            return await _learningPortalDBContext.SaveChangesAsync();
        }

        public Task<int> DeleteCourseByIdAsync(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Course>> GetCourseAsync()
        {
            return await _learningPortalDBContext.Courses.ToListAsync();
        }

        public Task<Course> GetCourseByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateCourseAsync(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
