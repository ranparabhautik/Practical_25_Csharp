using EmployeeManagement.DAL.Feature.Employee.Commands;
using EmployeeManagement.DAL.Feature.Employee.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateEmployeeCommand cmd)
        {
            var result = await _mediator.Send(cmd);
            return Ok(new
            {
                Message = $"Inserted Successfully ",
                Employee = result
            });
        }

        [HttpPut]
        public async Task<ActionResult> Update(UpdateEmployeeCommand cmd)
        {
            var result = await _mediator.Send(cmd);
            return Ok(new
            {
                Message = result
            });
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteEmployeeCommand
            {
                Id = id
            });
            return Ok(new
            {
               Message = result
            });
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployee(int? id)
        {
            var result = await _mediator.Send(new GetEmployeeQuery
            {
                Id  = id
            });
            return Ok(result);
        }
    }
}
