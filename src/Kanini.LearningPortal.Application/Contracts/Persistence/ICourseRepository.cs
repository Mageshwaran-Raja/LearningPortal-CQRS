using Kanini.LearningPortal.Domain.Entities;

namespace Kanini.LearningPortal.Application.Contracts.Persistence
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCourseAsync();
        Task<Course> GetCourseByIdAsync(Guid Id);
        Task<int> AddCourseAsync(Course course);
        Task<int> UpdateCourseAsync(Course course);
        Task<int> DeleteCourseByIdAsync(Guid courseId);
    }
}
