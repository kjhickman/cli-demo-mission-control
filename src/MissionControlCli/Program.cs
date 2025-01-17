using ConsoleAppFramework;
using Microsoft.Extensions.DependencyInjection;
using MissionControlCli.Commands;
using MissionControlCli.Services;

var app = ConsoleApp.Create()
    .ConfigureServices(services =>
    {
        // Reference Microsoft.Extensions.DependencyInjection to configure standard DI container
        services.AddSingleton<ITelemetryService, TelemetryService>();
    });

app.Add<Launch>();
app.Add<Status>("status");
app.Add<Abort>();

app.Run(args);
