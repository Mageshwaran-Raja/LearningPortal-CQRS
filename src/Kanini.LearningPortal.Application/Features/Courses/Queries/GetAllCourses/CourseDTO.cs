namespace Kanini.LearningPortal.Application.Features.Courses.Queries.GetAllCourses
{
    public class CourseDTO
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public string? CourseDescription { get; set; }
        public string CourseDuration { get; set; } = null!;

        public int? CourseDepartmentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}