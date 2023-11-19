using Kanini.LearningPortal.Application.Core;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Courses.Commands.AddCourse
{
    public class AddCourseCommand : IRequest<Result<Unit>>
    {
        public AddCourseDTO courseDTO;
    }
}
