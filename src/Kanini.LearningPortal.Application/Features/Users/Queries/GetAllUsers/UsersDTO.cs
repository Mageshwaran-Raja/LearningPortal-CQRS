namespace Kanini.LearningPortal.Application.Features.Users.Queries.GetAllUsers
{
    public class UsersDTO
    {
        public string MailId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int RoleId { get; set; }
        public string? ManagerMailId { get; set; }
        public string? ContactNumber { get; set; }
    }
}
