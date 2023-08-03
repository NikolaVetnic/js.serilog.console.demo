# Serilog Demo

A small demo project using Serilog for structured logging.

Observe [`./Practice_Serilog/Program.cs`](./Practice_Serilog/Program.cs). In the stated configuration, the `WriteTo.Console()` method will log the pretty-printed messages to the console, while the `WriteTo.File()` method will log the compact JSON formatted messages to the file at the provided path, creating a new file if it doesn't exist.

The `./logs/log.txt` path means that a logs directory will be created in the same directory as your project (if it doesn't already exist), and the logs will be written to a [`./Practice_Serilog/bin/Debug/net7.0/logs/log.txt`](./Practice_Serilog/bin/Debug/net7.0/logs/log.txt) file.

The `CompactJsonFormatter` is used to format logs as compact JSON objects, similar to what you saw on the console when you used this formatter previously.
