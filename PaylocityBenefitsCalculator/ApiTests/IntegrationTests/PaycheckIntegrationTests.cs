using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Api.Dtos.Dependent;
using Api.Dtos.Employee;
using Api.Dtos.Paycheck;
using Api.Models;
using Xunit;

namespace ApiTests.IntegrationTests;

public class PaycheckIntegrationTests : IntegrationTest
{
    [Fact]
    public async Task WhenThereAreNoDependents()
    {
        var response = await HttpClient.GetAsync("/api/v1/paycheck/1");
        var paycheck = new GetPaycheckDto
        {
            BaseAmount = 2900.81m,
            Deductions = 461,
            NetAmount = 2439.81m
        };

        await response.ShouldReturn(HttpStatusCode.OK, paycheck);
    }

    [Fact]
    public async Task WhenThereAreMultipleDependents()
    {
        var response = await HttpClient.GetAsync("/api/v1/paycheck/2");
        var paycheck = new GetPaycheckDto
        {
            BaseAmount = 3552.51m,
            Deductions = 1362.05m,
            NetAmount = 2190.46m
        };

        await response.ShouldReturn(HttpStatusCode.OK, paycheck);
    }
    
    [Fact]
    //task: make test pass
    public async Task WhenThereIsOneDependentOver50()
    {
        var response = await HttpClient.GetAsync("/api/v1/paycheck/3");
        var paycheck = new GetPaycheckDto
        {
            BaseAmount = 5508.12m,
            Deductions = 939.16m,
            NetAmount = 4568.96m
        };
       
        await response.ShouldReturn(HttpStatusCode.OK, paycheck);
    }

}