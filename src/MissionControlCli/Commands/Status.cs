using ConsoleAppFramework;
using MissionControlCli.Services;

namespace MissionControlCli.Commands;

public class Status(ITelemetryService telemetry)
{
    /// <summary>
    /// Check spacecraft systems
    /// </summary>
    /// <param name="system">-s, System to check (engines/life-support/comms)</param>
    /// <param name="verbose">-v, Show detailed information</param>
    [Command("systems")]
    public async Task Systems([Argument]string system, bool verbose = false)
    {
        Console.WriteLine($"Fetching telemetry for {system} systems...");
        var status = await telemetry.GetSystemStatus(system, verbose);
        Console.WriteLine(status);
    }
    
    /// <summary>
    /// Check crew status
    /// </summary>
    [Command("crew")]
    public async Task Crew()
    {
        var status = await telemetry.GetCrewStatus();
        Console.WriteLine(status);
    }
}
