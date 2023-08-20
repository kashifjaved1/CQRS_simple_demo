using CQRS_Demo.Data.Commands;
using CQRS_Demo.Data.Entities;
using CQRS_Demo.Repositories.Interfaces;
using MediatR;

namespace CQRS_Demo.Data.Handlers
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student
            {
                Name = request.Name,
                Grade = request.Grade,
                GPA = request.GPA,
            };

            return await _studentRepository.AddStudentAsync(student);
        }
    }
}
