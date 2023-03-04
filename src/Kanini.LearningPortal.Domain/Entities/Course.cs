using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanini.LearningPortal.Domain.Entities;

public partial class Course
{
    [Key]
    public Guid CourseId { get; set; }

    [StringLength(100)]
    public string CourseName { get; set; } = null!;

    [StringLength(300)]
    public string? CourseDescription { get; set; }

    [StringLength(30)]
    public string CourseDuration { get; set; } = null!;

    public int? CourseDepartmentId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [ForeignKey("CourseDepartmentId")]
    [InverseProperty("Courses")]
    public virtual Department? CourseDepartment { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<Material> Materials { get; } = new List<Material>();

    [InverseProperty("NominatedCourse")]
    public virtual ICollection<Nominee> Nominees { get; } = new List<Nominee>();
}
