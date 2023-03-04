using Kanini.LearningPortal.Application.Features.Courses.Queries.GetAllCourses;
using Microsoft.AspNetCore.Mvc;

namespace Kanini.LearningPortal.API.Controllers
{
    public class CourseController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllCourses()
        {
            return HandleResult(await Mediator.Send(new GetAllCoursesQuery())); 
        }
    }
}
