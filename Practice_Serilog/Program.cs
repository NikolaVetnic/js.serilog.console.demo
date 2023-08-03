using System;
using Serilog;

class Program
{
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console() // pretty print logs to the console
            .WriteTo.File(new Serilog.Formatting.Compact.CompactJsonFormatter(), "./logs/log.txt") // log objects to a file
            .CreateLogger();

        try
        {
            Log.Information("Starting up");

            // logs a structured event
            var position = new { Latitude = 25.0, Longitude = 134.0 };
            var elapsedMs = 34;

            Log.Information("Processed {@Position} in {Elapsed:000} ms.", position, elapsedMs);

            Log.Information("Shutting down");
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application start-up failed");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
