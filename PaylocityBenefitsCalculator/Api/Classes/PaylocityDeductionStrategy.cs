using Api.Dtos.Employee;
using Api.Dtos.Paycheck;

// This is a strategy to calculate pay and deductions accoding to the paylocity
// coding challenge requirements. Doing this adds flexabiity and extensibility to 
// the implementation. With more time you can add a feature to be able to use
// depdnency injection to inject concrete classes and strategies into the application,
// even at runtime. You could also put that into a microservice.

// Note: The approach I took to handle the fractions of a penny when
// dividing the base pay and deductions by 26 was to round everything down, then
// for the last paycheck paying out whatever pay is remaining for the year and deduct
// whatever deductions are remaining for the year. This seems like the best approach
// without asking the product team or legal about the correct way to do this and it does
// meet the requirements of splitting the deductions as evenly as possible. 
public class PaylocityDeductionStrategy : IDeductionsStrategy
{
    public List<GetPaycheckDto> CalculatePaychecks(GetEmployeeDto employee)
    {
        int numberOfDepenents = employee.Dependents.Count();

        // 26 paychecks per year with deductions spread as evenly as possible on each paycheck
        decimal basePay = employee.Salary / 26;

        // employees have a base cost of $1,000 per month (for benefits)
        decimal yearlyBenefitCost = (1000 * 12);
        decimal benefitCost = yearlyBenefitCost / 26;

        // each dependent represents an additional $600 cost per month (for benefits)
        yearlyBenefitCost += numberOfDepenents * 600 * 12;
        benefitCost += (numberOfDepenents * 600 * 12) / 26;

        // employees that make more than $80,000 per year will incur an additional 2% of their yearly salary in
        // benefits costs

        if (employee.Salary > 80000)
        {
            yearlyBenefitCost += .02M * employee.Salary;
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
                yearlyBenefitCost += (200 * 12);
                benefitCost += (200 * 12) / 26;
            }

        }

        decimal baseAmount = Math.Round(basePay, MidpointRounding.ToNegativeInfinity);
        decimal deductions = Math.Round(benefitCost, MidpointRounding.ToNegativeInfinity);

        var paycheck = new GetPaycheckDto
        {
            BaseAmount = baseAmount,
            Deductions = deductions,
            NetAmount = baseAmount - deductions
        };

        List<GetPaycheckDto> paychecksResult = new();

        for (int i = 0; i < 25; ++i)
        {
            paychecksResult.Add(paycheck);
        }

        // Calculating the last paycheck
        // BaseAmount is going to be whatever pay hasn't been payed out for the year
        // Deductions are going to be whatever deductions haven't been payed out for the year
        // Final Net Amount is BaseAmount - Deductions.
        // I rounded up both the pay and deductions to the nearest cent. I would probably ask the product team
        // or legal how to handle fractions of a cent but for now I think this is the best way. 

        var lastBaseAmount = Math.Round(employee.Salary - (baseAmount * 25), 2, MidpointRounding.ToPositiveInfinity);
        var lastDeductions = Math.Round(yearlyBenefitCost - (deductions * 25), 2, MidpointRounding.ToPositiveInfinity);
        var lastNetAmount = lastBaseAmount - lastDeductions;

        var lastPaycheck = new GetPaycheckDto
        {
            BaseAmount = lastBaseAmount,
            Deductions = lastDeductions,
            NetAmount = lastNetAmount
        };

        paychecksResult.Add(lastPaycheck);

        return paychecksResult;
    }

}