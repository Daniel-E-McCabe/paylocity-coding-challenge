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
        var paycheck = new List<GetPaycheckDto>
        {
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2900,
                Deductions = 461,
                NetAmount = 2439
            },
            new()
            {
                BaseAmount = 2920.99m,
                Deductions = 475,
                NetAmount = 2445.99m
            }
        };

            await response.ShouldReturn(HttpStatusCode.OK, paycheck);
        }

    [Fact]
    public async Task WhenThereAreMultipleDependents()
    {
        var response = await HttpClient.GetAsync("/api/v1/paycheck/2");
        var paycheck = new List<GetPaycheckDto>
        {
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3552,
                Deductions = 1362,
                NetAmount = 2190
            },
            new()
            {
                BaseAmount = 3565.22m,
                Deductions = 1397.31m,
                NetAmount = 2167.91m
            }
        };

        await response.ShouldReturn(HttpStatusCode.OK, paycheck);
    }
    
    [Fact]
    //task: make test pass
    public async Task WhenThereIsOneDependentOver50()
    {
        var response = await HttpClient.GetAsync("/api/v1/paycheck/3");
        var paycheck = new List<GetPaycheckDto>
        {
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5508,
                Deductions = 939,
                NetAmount = 4569
            },
            new()
            {
                BaseAmount = 5511.12m,
                Deductions = 989.23m,
                NetAmount = 4521.89m
            }
        };

        await response.ShouldReturn(HttpStatusCode.OK, paycheck);
    }

}