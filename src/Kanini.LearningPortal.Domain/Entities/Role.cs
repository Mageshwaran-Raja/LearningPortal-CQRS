using Kanini.LearningPortal.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanini.LearningPortal.Persistence;

public partial class Role
{
    [Key]
    public int RoleId { get; set; }

    [StringLength(10)]
    public string RoleName { get; set; } = null!;

    [InverseProperty("Role")]
    public virtual ICollection<User> Users { get; } = new List<User>();
}
