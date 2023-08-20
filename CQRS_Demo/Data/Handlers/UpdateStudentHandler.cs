using CQRS_Demo.Data.Commands;
using CQRS_Demo.Data.Entities;
using CQRS_Demo.Repositories.Interfaces;
using MediatR;

namespace CQRS_Demo.Data.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public UpdateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Id = request.Id,
                Name = request.Name,
                Grade = request.Grade,
                GPA = request.GPA
            };

            return await _studentRepository.UpdateStudentAsync(student);
        }
    }
}
