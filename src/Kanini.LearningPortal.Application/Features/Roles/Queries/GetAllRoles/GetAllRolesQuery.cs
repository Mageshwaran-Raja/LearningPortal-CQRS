using Kanini.LearningPortal.Application.Core;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Roles.Queries.GetAllRoles
{
    public class GetAllRolesQuery : IRequest<Result<List<RoleDTO>>>
    {
    }
}
