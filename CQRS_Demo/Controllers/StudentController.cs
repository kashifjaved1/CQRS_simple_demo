using CQRS_Demo.Data.Commands;
using CQRS_Demo.Data.Entities;
using CQRS_Demo.Data.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Students()
        {
            // mediator will always send n in send uses query/command, and it'll automatically finds the appropriate handler for it.
            var students = await _mediator.Send(new GetStudentListQuery());
            return Ok(students);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Student(int Id)
        {
            var student = await _mediator.Send(new GetStudentByIdQuery() { Id = Id });
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            return Ok(await _mediator.Send(new CreateStudentCommand(student)));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Student student)
        {
            return Ok(await _mediator.Send(new UpdateStudentCommand(student)));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await _mediator.Send(new DeleteStudentCommand() { Id = Id}));
        }
    }
}
