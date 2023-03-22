namespace Kanini.LearningPortal.Application.Features.Users.Commands.AddUser
{
    public class AddUserDTO
    {
        public string MailId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int RoleId { get; set; }
        public string? ManagerMailId { get; set; }
        public string? ContactNumber { get; set; }
        public string Password { get; set; } = null!;
    }
}
