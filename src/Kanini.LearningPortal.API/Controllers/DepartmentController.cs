using Kanini.LearningPortal.Application.Features.Courses.Queries.GetAllCourses;
using Kanini.LearningPortal.Application.Features.Departments.Queries.GetAllDepartments;
using Microsoft.AspNetCore.Mvc;

namespace Kanini.LearningPortal.API.Controllers
{
    public class DepartmentController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            return HandleResult(await Mediator.Send(new GetAllDepartmentsQuery()));
        }
    }
}
