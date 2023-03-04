using Kanini.LearningPortal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Kanini.LearningPortal.Persistence.DatabaseContext;

public partial class LearningPortalDBContext : DbContext
{
    public LearningPortalDBContext()
    {
    }

    public LearningPortalDBContext(DbContextOptions<LearningPortalDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Nominee> Nominees { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__C92D71A7095ABED3");

            entity.ToTable(tb => tb.HasTrigger("trg_course_updatemodifiedDate"));

            entity.Property(e => e.CourseId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CourseDepartment).WithMany(p => p.Courses).HasConstraintName("FK__Courses__CourseD__4AB81AF0");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BED312257E5");

            entity.Property(e => e.DepartmentId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Material__3214EC070974758C");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Course).WithMany(p => p.Materials).HasConstraintName("FK__Materials__Cours__4BAC3F29");
        });

        modelBuilder.Entity<Nominee>(entity =>
        {
            entity.HasKey(e => e.NomineeId).HasName("PK__Nominees__40B5EA168A42FBF8");

            entity.Property(e => e.NomineeId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.NominatedCourse).WithMany(p => p.Nominees).HasConstraintName("FK__Nominees__Nomina__4D94879B");

            entity.HasOne(d => d.NomineeMail).WithMany(p => p.Nominees).HasConstraintName("FK__Nominees__Nomine__4CA06362");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1AC5272F67");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.MailId).HasName("PK__Users__09A8749A8BB8C656");

            entity.Property(e => e.Password).IsFixedLength();

            entity.HasOne(d => d.ManagerMail).WithMany(p => p.InverseManagerMail).HasConstraintName("FK__Users__ManagerMa__4F7CD00D");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__RoleId__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
