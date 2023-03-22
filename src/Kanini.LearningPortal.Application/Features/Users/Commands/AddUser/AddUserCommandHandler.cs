using AutoMapper;
using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Application.Core;
using Kanini.LearningPortal.Domain.Entities;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Users.Commands.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Result<Unit>>
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public AddUserCommandHandler(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<Result<Unit>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);

            var result = await _usersRepository.AddUser(user);

            if (result < 1) return Result<Unit>.Failure("Failed to Add User Data");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}
