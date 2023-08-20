using CQRS_Demo.Data.Entities;
using MediatR;

namespace CQRS_Demo.Data.Commands
{
    public class CreateStudentCommand : IRequest<Student>
    {
        // in command these properties are not filters but the returning ones after successful operations.

        public CreateStudentCommand(Student student)
        {
            Name = student.Name;
            Grade = student.Grade;
            GPA = student.GPA;
        }

        public string Name { get; set; }
        public int Grade { get; set; }
        public int GPA { get; set; }
    }
}
