using System.Text.Json.Serialization;

namespace Kanini.LearningPortal.Application.Features.Courses.Commands.AddCourse
{
    public class AddCourseDTO
    {
        [JsonIgnore]
        public Guid CourseId = Guid.NewGuid();
        public string CourseName { get; set; } = null!;
        public string? CourseDescription { get; set; }
        public string CourseDuration { get; set; } = null!;

        public int? CourseDepartmentId { get; set; }
    }
}
