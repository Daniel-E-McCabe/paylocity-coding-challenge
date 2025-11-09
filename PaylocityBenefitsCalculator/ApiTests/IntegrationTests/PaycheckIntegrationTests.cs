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
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
             new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.80m,
                Deductions = 461.53m,
                NetAmount = 2439.27m
            },
            new()
            {
                BaseAmount = 2900.99m,
                Deductions = 461.75m,
                NetAmount = 2439.24m
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
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
             new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.50m,
                Deductions = 1363.35m,
                NetAmount = 2189.15m
            },
            new()
            {
                BaseAmount = 3552.72m,
                Deductions = 1363.56m,
                NetAmount = 2189.16m
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
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.93m,
                NetAmount = 4567.19m
            },
            new()
            {
                BaseAmount = 5508.12m,
                Deductions = 940.98m,
                NetAmount = 4567.14m
            }
        };

        await response.ShouldReturn(HttpStatusCode.OK, paycheck);
    }

}