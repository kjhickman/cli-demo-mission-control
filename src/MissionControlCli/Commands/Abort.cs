using ConsoleAppFramework;

namespace MissionControlCli.Commands;

public class Abort
{
    /// <summary>
    /// Abort current mission
    /// </summary>
    /// <param name="force">-f, Skip confirmation</param>
    [Command("abort")]
    public async Task Execute(bool force)
    {
        if (!force)
        {
            Console.Write("Are you sure you want to abort the mission? (y/N): ");
            var response = Console.ReadLine()?.ToLower();
            if (response != "y")
            {
                Console.WriteLine("Abort cancelled");
                return;
            }
        }
        Console.WriteLine("Mission abort sequence initiated");
        await Task.Delay(1000);
        Console.WriteLine("All systems shutting down");
        await Task.Delay(1000);
        Console.WriteLine("Mission aborted");
    }
}