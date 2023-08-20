using CQRS_Demo.Data.Commands;
using CQRS_Demo.Repositories.Interfaces;
using MediatR;

namespace CQRS_Demo.Data.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;

        public DeleteStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            return await _studentRepository.DeleteStudentAsync(request.Id);
        }
    }
}
