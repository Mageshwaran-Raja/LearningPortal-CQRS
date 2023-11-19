using System.ComponentModel.DataAnnotations;

namespace Kanini.LearningPortal.Application.Features.Departments.Queries.GetAllDepartments
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
    }
}
