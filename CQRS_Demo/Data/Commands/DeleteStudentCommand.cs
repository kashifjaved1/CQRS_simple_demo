using MediatR;

namespace CQRS_Demo.Data.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
