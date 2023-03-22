using Kanini.LearningPortal.Domain.Entities;

namespace Kanini.LearningPortal.Application.Contracts.Persistence
{
    public interface IAuthenticationRepository
    {
        Task<User> Login();
    }
}
