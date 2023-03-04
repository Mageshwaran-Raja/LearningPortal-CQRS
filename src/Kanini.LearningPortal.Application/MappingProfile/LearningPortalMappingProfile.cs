using AutoMapper;
using Kanini.LearningPortal.Application.Features.Courses.Queries.GetAllCourses;
using Kanini.LearningPortal.Domain.Entities;

namespace Kanini.LearningPortal.Application.MappingProfile
{
    public class LearningPortalMappingProfile : Profile
    {
        public LearningPortalMappingProfile()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
        }
    }
}
