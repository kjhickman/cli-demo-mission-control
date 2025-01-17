using ConsoleAppFramework;

namespace MissionControlCli.Commands;

public class Launch
{
    /// <summary>
    /// Launch a spacecraft
    /// </summary>
    /// <param name="destination">-d, Destination (moon/mars/orbit)</param>
    /// <param name="missionName">-n, Name of the mission</param>
    /// <param name="crewSize">-c, Number of crew members</param>
    [Command("launch")]
    public async Task Execute(string destination, string missionName = "Voyager 1", int crewSize = 0)
    {
        Console.WriteLine($"Launching mission {missionName} to {destination} with {crewSize} crew members");
        // Simulate launch sequence
        await Task.Delay(1000);
        Console.WriteLine("3...");
        await Task.Delay(1000);
        Console.WriteLine("2...");
        await Task.Delay(1000);
        Console.WriteLine("1...");
        await Task.Delay(1000);
        Console.WriteLine("Liftoff!");
    }
}