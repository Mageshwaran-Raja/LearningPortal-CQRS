using AutoMapper;
using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Application.Core;
using Kanini.LearningPortal.Domain.Entities;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Courses.Commands.AddCourse
{
    public class AddCourseCommandHandler : IRequestHandler<AddCourseCommand, Result<Unit>>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        public AddCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<Result<Unit>> Handle(AddCourseCommand request, CancellationToken cancellationToken)
        {
            var course = _mapper.Map<Course>(request.courseDTO);
            var result = await _courseRepository.AddCourseAsync(course) > 0;

            if (!result) return Result<Unit>.Failure("Failed to create course");

            return Result<Unit>.Success(Unit.Value);
        }
    }
}
