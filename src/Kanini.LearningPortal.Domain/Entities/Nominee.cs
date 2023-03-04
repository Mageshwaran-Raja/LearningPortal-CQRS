using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanini.LearningPortal.Domain.Entities;

public partial class Nominee
{
    [Key]
    public Guid NomineeId { get; set; }

    [Column("NomineeMailID")]
    [StringLength(100)]
    public string? NomineeMailId { get; set; }

    [Column("NominatedCourseID")]
    public Guid? NominatedCourseId { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NominatedDate { get; set; }

    public bool? CourseAcceptedStatus { get; set; }

    [ForeignKey("NominatedCourseId")]
    [InverseProperty("Nominees")]
    public virtual Course? NominatedCourse { get; set; }

    [ForeignKey("NomineeMailId")]
    [InverseProperty("Nominees")]
    public virtual User? NomineeMail { get; set; }
}
