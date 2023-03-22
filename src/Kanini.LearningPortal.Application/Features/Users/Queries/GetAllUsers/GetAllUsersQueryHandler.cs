using AutoMapper;
using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Application.Core;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, Result<List<UsersDTO>>>
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<Result<List<UsersDTO>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = Result<List<UsersDTO>>.Success(_mapper.Map<List<UsersDTO>>(
                (await _usersRepository.GetAllUsers())));
            return users;
        }
    }
}
