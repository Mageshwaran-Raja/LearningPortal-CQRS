using AutoMapper;
using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Application.Core;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Roles.Queries.GetAllRoles
{
    public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, Result<List<RoleDTO>>>
    {
        private readonly IRolesRepository _rolesRepository;
        private readonly IMapper _mapper;

        public GetAllRolesQueryHandler(IRolesRepository rolesRepository, IMapper mapper)
        {
            _rolesRepository = rolesRepository;
            _mapper = mapper;
        }
        public async Task<Result<List<RoleDTO>>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = Result<List<RoleDTO>>.Success(_mapper.Map<List<RoleDTO>>(
                await _rolesRepository.GetAllRolesAsync()));

            return roles;
        }
    }
}
