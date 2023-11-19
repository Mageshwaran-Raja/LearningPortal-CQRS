using AutoMapper;
using Kanini.LearningPortal.Application.Contracts.Persistence;
using Kanini.LearningPortal.Application.Core;
using MediatR;

namespace Kanini.LearningPortal.Application.Features.Departments.Queries.GetAllDepartments
{
    public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, Result<List<DepartmentDTO>>>
    {
        private readonly IDepartmentsRepository _departmentRepository;
        private readonly IMapper _mapper;
        public GetAllDepartmentsQueryHandler(IDepartmentsRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task<Result<List<DepartmentDTO>>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            return Result<List<DepartmentDTO>>.Success(_mapper.Map<List<DepartmentDTO>>(
                await _departmentRepository.GetAllDepartmentsAsync()));
        }
    }
}
