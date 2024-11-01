using _5W2H.Application.Commands.DepartmentCommands.InsertDepartment;
using _5W2H.Application.Queries.DepartmentQueries.GetAllDepartments;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace _5W2H.Api.Controllers;

[ApiController]
[Route("/api/departments")]
public class DepartmentController : ControllerBase
{
    private readonly IMediator _mediator;
    public DepartmentController(IMediator mediator)
    {
        _mediator = mediator;
            
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var query = new GetAllDepartmentsQuery();
        var result = await _mediator.Send(query);
        
        return Ok(result);
    }
    
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] InsertSetorCommand command)
    {
        var result = await _mediator.Send(command);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}