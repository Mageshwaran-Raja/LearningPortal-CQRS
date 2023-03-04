using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanini.LearningPortal.Domain.Entities;

public partial class Material
{
    [Key]
    public Guid Id { get; set; }

    public Guid? CourseId { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(100)]
    public string? ContentType { get; set; }

    public byte[]? Data { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Materials")]
    public virtual Course? Course { get; set; }
}
