using Api.Dtos.Paycheck;
using Api.Dtos.Employee;

// Interface that's implemented to create deduction calculation strategies
interface IDeductionsStrategy
{
    List<GetPaycheckDto> CalculatePaychecks(GetEmployeeDto employee);
}