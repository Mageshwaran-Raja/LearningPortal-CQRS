using Kanini.LearningPortal.Application.Features.Roles.Queries.GetAllRoles;
using Microsoft.AspNetCore.Mvc;

namespace Kanini.LearningPortal.API.Controllers
{
    public class RolesController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            return HandleResult(await Mediator.Send(new GetAllRolesQuery()));
        }
    }
}
