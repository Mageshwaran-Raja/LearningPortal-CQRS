using AutoMapper;
using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Application.Core;
using Kanini.LearningPortal.Application.Features.Users.Queries.GetAllUsers;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Users.Queries.GetUserByMailId
{
    public class GetUserByMailIdQueryHandler : IRequestHandler<GetUserByMailIdQuery, Result<UsersDTO>>
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public GetUserByMailIdQueryHandler(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }
        public async Task<Result<UsersDTO>> Handle(GetUserByMailIdQuery request, CancellationToken cancellationToken)
        {

            var result = await _usersRepository.GetUserByMailIdAsync(request.MailId);

            return Result<UsersDTO>.Success(_mapper.Map<UsersDTO>(result));

        }
    }
}
