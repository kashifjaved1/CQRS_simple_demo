using CQRS_Demo.Data.Entities;
using CQRS_Demo.Data.Queries;
using CQRS_Demo.Repositories.Interfaces;
using MediatR;

namespace CQRS_Demo.Data.Handlers
{
    public class GetStuentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStuentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
