using CQRS_Demo.Data.Entities;
using MediatR;

namespace CQRS_Demo.Data.Commands
{
    public class UpdateStudentCommand : IRequest<int>
    {
        public UpdateStudentCommand(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            Grade = student.Grade;
            GPA = student.GPA;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int GPA { get; set; }
    }
}
