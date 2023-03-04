using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanini.LearningPortal.Domain.Entities;

public partial class Department
{
    [Key]
    public int DepartmentId { get; set; }

    [StringLength(30)]
    public string DepartmentName { get; set; } = null!;

    [InverseProperty("CourseDepartment")]
    public virtual ICollection<Course> Courses { get; } = new List<Course>();
}
