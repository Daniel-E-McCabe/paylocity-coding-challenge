using Api.Dtos.Employee;
using Api.Dtos.Paycheck;
using Api.Models;
using Api.Classes.Data;

using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PaycheckController : ControllerBase
{
    // Function to get the paycheck amounts for an employee
    // Note: I wasn't sure what to do with precision in the calculations so I left it at the 
    // decimal precision, rounded the deductions down and the basepay per pay period up to the
    // nearest penny. At previous jobs I would ask Product and they can ask Legal if need be. 
    [SwaggerOperation(Summary = "Get Paycheck for Employee")]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GetPaycheckDto>>> Get(int id)
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

        int numberOfDepenents = employee.Dependents.Count();

        // 26 paychecks per year with deductions spread as evenly as possible on each paycheck
        decimal basePay = employee.Salary / 26;
        
        // employees have a base cost of $1,000 per month (for benefits)
        decimal benefitCost = (1000 * 12) / 26;

        // each dependent represents an additional $600 cost per month (for benefits)
        benefitCost += (numberOfDepenents * 600 * 12) / 26;

        // employees that make more than $80,000 per year will incur an additional 2% of their yearly salary in
        // benefits costs

        if (employee.Salary > 80000)
        {
            benefitCost += (.02M * employee.Salary) / 26;
        }

        // dependents that are over 50 years old will incur an additional $200 per month
        DateTime today = DateTime.Today;
        foreach (var dependent in employee.Dependents)
        {
            int yearsDifference = today.Year - dependent.DateOfBirth.Year;
            int age = yearsDifference;
            if (dependent.DateOfBirth.Date > today.AddYears(-yearsDifference))
            {
                age -= 1;
            }

            if (age > 50)
            {
                benefitCost += (200 * 12) / 26;
            }

        }

        decimal baseAmount = Math.Round(basePay, 2, MidpointRounding.ToPositiveInfinity);
        decimal deductions = Math.Round(benefitCost, 2, MidpointRounding.ToNegativeInfinity);

        var paycheck = new GetPaycheckDto
        {
            BaseAmount = baseAmount,
            Deductions = deductions,
            NetAmount = baseAmount - deductions
        };

        var result = new ApiResponse<GetPaycheckDto>
        {
            Data = paycheck,
            Success = true
        };

        return result;
    }
}
