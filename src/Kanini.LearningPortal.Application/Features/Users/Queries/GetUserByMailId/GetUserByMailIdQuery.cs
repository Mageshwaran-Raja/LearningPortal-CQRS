using Kanini.LearningPortal.Application.Core;
using Kanini.LearningPortal.Application.Features.Users.Queries.GetAllUsers;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Users.Queries.GetUserByMailId
{
    public class GetUserByMailIdQuery : IRequest<Result<UsersDTO>>
    {
        public string MailId { get; set; } = null!;
    }
}
