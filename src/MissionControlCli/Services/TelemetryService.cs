namespace MissionControlCli.Services;

public interface ITelemetryService
{
    Task<string> GetSystemStatus(string systemName, bool verbose);
    Task<string> GetCrewStatus();
}

public class TelemetryService : ITelemetryService
{
    public async Task<string> GetSystemStatus(string systemName, bool verbose)
    {
        // Simulate fetching real telemetry data
        await Task.Delay(Random.Shared.Next(500, 1500)); // Simulate network delay

        var systemHealth = Random.Shared.Next(0, 100);
        var status = systemHealth > 80 ? "nominal" : 
            systemHealth > 50 ? "requires attention" : 
            "critical";

        if (!verbose)
            return $"{systemName} systems {status}";

        return $"""
                {systemName} System Status:
                Health: {systemHealth}%
                Status: {status}
                Power Draw: {Random.Shared.Next(50, 150)}kW
                Last Maintenance: {DateTime.Now.AddDays(-Random.Shared.Next(1, 30)):d}
                Active Alerts: {Random.Shared.Next(0, 3)}
                """;
    }

    public async Task<string> GetCrewStatus()
    {
        await Task.Delay(Random.Shared.Next(500, 1000));
        var crewStatuses = new[] { "nominal", "resting", "exercising", "conducting experiments" };
        return $"Crew status: {crewStatuses[Random.Shared.Next(crewStatuses.Length)]}";
    }
}