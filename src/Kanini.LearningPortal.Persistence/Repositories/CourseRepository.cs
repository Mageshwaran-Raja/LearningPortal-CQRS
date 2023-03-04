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
            this._learningPortalDBContext = learningPortalDBContext;
        }
        public async Task<List<Course>> GetCourseAsync()
        {
            return await _learningPortalDBContext.Courses.ToListAsync();
        }
    }
}
