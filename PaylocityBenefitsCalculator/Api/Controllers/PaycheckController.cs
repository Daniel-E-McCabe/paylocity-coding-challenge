using Api.Dtos.Employee;
using Api.Dtos.Paycheck;
using Api.Models;
using Api.Classes.Data;
using Api.Classes;

using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PaycheckController : ControllerBase
{
    // Function to get the paycheck amounts for an employee
    // I used a strategy pattern in order to add flexability and extensability to the
    // controller by placing the calculation logic into a concrete PaylocityDeductionStrategy
    // object. If the calculations or business logic changes, you can create a new concrete
    // class, or add functionality to use dependency injection to add concrete classes, even during
    // runtime.

    [SwaggerOperation(Summary = "Get Paycheck for Employee")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<List<GetPaycheckDto>>>> Get(int id)
    {
        IEnumerable<GetEmployeeDto> findEmployee =
            from e in Data.Employees
            where e.Id == id
            select e;

        if (findEmployee.Count() > 1)
        {
            return BadRequest("Problem with the data, more than 1 employees were returned");
        }

        if (findEmployee.Count() == 0)
        {
            return NotFound("Employee with id " + id + " not found");
        }

        GetEmployeeDto employee = findEmployee.First<GetEmployeeDto>();

        var paychecksResult = CalculatePaychecks(new PaylocityDeductionStrategy(), employee);

        var result = new ApiResponse<List<GetPaycheckDto>>
        {
            Data = paychecksResult,
            Success = true
        };

        return result;
    }
    
    private List<GetPaycheckDto> CalculatePaychecks(IDeductionsStrategy strategy, GetEmployeeDto employee)
    {
        return strategy.CalculatePaychecks(employee);
    }
}
