namespace Api.Dtos.Paycheck;

public class GetPaycheckDto
{
    public decimal BaseAmount { get; set; }
    public decimal Deductions { get; set; }
    public decimal NetAmount { get; set; }
}