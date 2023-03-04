using Kanini.LearningPortal.Persistence;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanini.LearningPortal.Domain.Entities;

public partial class User
{
    [Key]
    [StringLength(100)]
    public string MailId { get; set; } = null!;

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int RoleId { get; set; }

    [StringLength(100)]
    public string? ManagerMailId { get; set; }

    [StringLength(20)]
    public string? ContactNumber { get; set; }

    [MaxLength(64)]
    public byte[] Password { get; set; } = null!;

    public Guid? Salt { get; set; }

    [InverseProperty("ManagerMail")]
    public virtual ICollection<User> InverseManagerMail { get; } = new List<User>();

    [ForeignKey("ManagerMailId")]
    [InverseProperty("InverseManagerMail")]
    public virtual User? ManagerMail { get; set; }

    [InverseProperty("NomineeMail")]
    public virtual ICollection<Nominee> Nominees { get; } = new List<Nominee>();

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role Role { get; set; } = null!;
}
