using Kanini.LearningPortal.Application.Features.Users.Commands.AddUser;
using Kanini.LearningPortal.Application.Features.Users.Queries.GetAllUsers;
using Kanini.LearningPortal.Application.Features.Users.Queries.GetUserByMailId;
using Microsoft.AspNetCore.Mvc;

namespace Kanini.LearningPortal.API.Controllers
{
    public class UsersController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return HandleResult(await Mediator.Send(new GetAllUsersQuery()));
        }

        [HttpGet("{mailId}")]
        public async Task<IActionResult> GetUserByMailId(string mailId)
        {
            return HandleResult(await Mediator.Send(new GetUserByMailIdQuery { MailId = mailId}));
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserCommand addUser)
        {
            return HandleResult(await Mediator.Send(addUser));   
        }
    }
}
