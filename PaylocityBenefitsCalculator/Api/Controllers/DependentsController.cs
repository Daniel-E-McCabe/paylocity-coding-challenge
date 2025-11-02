using Api.Classes.Data;
using Api.Dtos.Dependent;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class DependentsController : ControllerBase
{
    [SwaggerOperation(Summary = "Get dependent by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetDependentDto>>> Get(int id)
    {
        foreach (var employee in Data.Employees)
        {
            // Look for dependent
            foreach (var dependent in employee.Dependents)
            {
                if (dependent.Id == id)
                {
                    var result = new ApiResponse<GetDependentDto>
                    {
                        Data = dependent,
                        Success = true
                    };

                    return result;
                }
            }
        }

        return NotFound("Dependent with id " + id + " doesn't exist");
    }

    [SwaggerOperation(Summary = "Get all dependents")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetDependentDto>>>> GetAll()
    {
        List<GetDependentDto> allDependents = new(); 

        foreach(var employee in Data.Employees)
        {
            allDependents.AddRange(employee.Dependents);
        }

        var result = new ApiResponse<List<GetDependentDto>>
        {
            Data = allDependents,
            Success = true
        };

        return result;
    }
}
