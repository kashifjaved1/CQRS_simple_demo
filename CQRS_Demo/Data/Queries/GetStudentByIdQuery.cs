using CQRS_Demo.Data.Entities;
using MediatR;

namespace CQRS_Demo.Data.Queries
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        // id here as it'll work as search_filter and required to get specific student.
        public int Id { get; set; }
    }
}
