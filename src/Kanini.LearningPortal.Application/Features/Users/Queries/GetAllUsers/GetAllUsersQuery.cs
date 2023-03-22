using Kanini.LearningPortal.Application.Core;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<Result<List<UsersDTO>>> { }
}
