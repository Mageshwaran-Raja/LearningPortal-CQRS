using AutoMapper;
using Kanini.LearningPortal.Application.Features.Courses.Commands.AddCourse;
using Kanini.LearningPortal.Application.Features.Courses.Queries.GetAllCourses;
using Kanini.LearningPortal.Application.Features.Departments.Queries.GetAllDepartments;
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
            CreateMap<Course, AddCourseDTO>().ReverseMap();

            CreateMap<User, UsersDTO>().ReverseMap();
            CreateMap<Role, RoleDTO>().ReverseMap();

            CreateMap<User, AddUserCommand>().ReverseMap();

            CreateMap<Department, DepartmentDTO>().ReverseMap();
        }
    }
}
