using Kanini.LearningPortal.Domain.Entities;

namespace Kanini.LearningPortal.Application.Contracts.Persistence
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCourseAsync();
    }
}
