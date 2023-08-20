using CQRS_Demo.Data.Entities;
using MediatR;

namespace CQRS_Demo.Data.Queries
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
        // nothing here as no filter is requied to get all students.
    }
}
