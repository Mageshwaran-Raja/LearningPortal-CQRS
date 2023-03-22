using AutoMapper;
using Kanini.LearningPortal.Application.Features.Courses.Queries.GetAllCourses;
using Kanini.LearningPortal.Application.Features.Roles.Queries.GetAllRoles;
using Kanini.LearningPortal.Application.Features.Users.Commands.AddUser;
using Kanini.LearningPortal.Application.Features.Users.Queries.GetAllUsers;
using Kanini.LearningPortal.Domain.Entities;
using Kanini.LearningPortal.Persistence;

namespace Kanini.LearningPortal.Application.MappingProfile
{
    public class LearningPortalMappingProfile : Profile
    {
        public LearningPortalMappingProfile()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<User, UsersDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();

            CreateMap<User, AddUserCommand>().ReverseMap();
        }
    }
}
