using AutoMapper;
using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Application.Core;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Courses.Queries.GetAllCourses
{
    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, Result<List<CourseDTO>>>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        public GetAllCoursesQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<Result<List<CourseDTO>>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            var courses = Result<List<CourseDTO>>.Success(_mapper.Map<List<CourseDTO>>(
                (await _courseRepository.GetCourseAsync())));
            return courses;
        }
    }
}
