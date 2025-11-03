using Api.Dtos.Dependent;
using Api.Dtos.Employee;
using Api.Models;
using Api.Classes.Data;

using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;


// I added a REST endpoint to add an employee so that I could enforce the requirements about the number of spouses
// and domestic partners an employee could have
[ApiController]
[Route("api/v1/[controller]")]
public class EmployeesController : ControllerBase
{
    [SwaggerOperation(Summary = "Get employee by id")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetEmployeeDto>>> Get(int id)
    {
        IEnumerable<GetEmployeeDto> employees =
            from employee in Data.Employees
            where employee.Id == id
            select employee;

        if (employees.Count() > 1)
        {
            return BadRequest("Problem with the data, more than 1 employees were returned");
        }

        if (employees.Count() == 0)
        {
            return NotFound("Employee with " + id + " not found");
        }

        var result = new ApiResponse<GetEmployeeDto>
        {
            Data = employees.First(),
            Success = true
        };

        return result;
    }

    [SwaggerOperation(Summary = "Get all employees")]
    [HttpGet("")]
    public async Task<ActionResult<ApiResponse<List<GetEmployeeDto>>>> GetAll()
    {
        var result = new ApiResponse<List<GetEmployeeDto>>
        {
            Data = Data.Employees,
            Success = true
        };

        return result;
    }
    
       
    [SwaggerOperation(Summary = "Add Employee")]
    [HttpPost("")]
    public async Task<IActionResult> Add(
        [FromBody] GetEmployeeDto employee
    )
    {
        // Check Dependent Rules
        IEnumerable<GetDependentDto> spousesOrDomesticPartners =
            from dependent in employee.Dependents
            where dependent.Relationship == Relationship.Spouse || dependent.Relationship == Relationship.Spouse
            select dependent;

        if(spousesOrDomesticPartners.Count() > 1)
        {
            return BadRequest("Too many Spouses or Domestic Partners. Employees are limited to 1");
        }

        Data.Employees.Add(employee);
        

        return Ok(new { message = "Employee added successfully" });
    }
}
