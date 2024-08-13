using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FSH.WebApi.Infrastructure;

public class HealthCheck : IHealthCheck
{
    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        // Descoped
        HealthCheckResult check = new HealthCheckResult(HealthStatus.Healthy);
        return Task.FromResult(check);
    }
}