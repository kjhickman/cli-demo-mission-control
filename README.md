# Mission Control CLI Demo

This app doesn't actually do anything. It's meant as a sample/reference for [ConsoleAppFramework](https://github.com/Cysharp/ConsoleAppFramework), showcasing commands, arguments, options, subcommands etc. Check out the ConsoleAppFramework repo for more info, but some of the key reasons I prefer it for CLI apps:
- It's fast
- It supports idiomatic dependency injection
- It's NativeAOT-compatible
- POSIX-style conventions (not fully compliant)

## Key Framework Features Demonstrated

- **Command-based structure**: Each operation (`launch`, `status`, `abort`) is a separate class decorated with `[Command]` attributes
- **Automatic command-line parsing**: Parameters are automatically mapped to method arguments with support for:
  - Required params: `destination` in Launch command
  - Optional params with defaults: `missionName = "Voyager 1"` in Launch command
  - Boolean flags: `verbose` in Status command, `force` in Abort command
- **Built-in help text**: XML documentation comments are automatically converted to help messages and option aliases
- **Dependency injection**: See `TelemetryService` injection in Status command

## Quick Start

```bash
# See default help screen
dotnet run

# Launch to Mars with 3 crew members
dotnet run -- launch -d mars -c 3

# Check engine status (verbose)
dotnet run -- status systems -s engines -v

# Force abort without confirmation
dotnet run -- abort -f
```