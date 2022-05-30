using Serilog;
using Serilog.Events;

namespace WebAPI2BoilerPlate.Logging
{
    //Use this class to separate out logs by log-level. In that case do not use ILogHelper.
    //To use this class install 2 packages “Serilog” and “Serilog.Sinks.File” from NuGet package
    public static class Logger
    {
        private static readonly ILogger _logger;


        static Logger()
        {
            // 5 MB = 5242880 bytes

            _logger = new LoggerConfiguration()
                .ReadFrom.AppSettings()
                .CreateLogger();
        }

        public static void Error(System.Exception ex, string message)
        {
            //Error - indicating a failure within the application or connected system
            _logger.Write(LogEventLevel.Error, ex, message);
        }

        public static void Warning(System.Exception ex, string message)
        {
            //Warning - indicators of possible issues or service / functionality degradation
            _logger.Write(LogEventLevel.Warning, ex, message);
        }

        public static void Debug(System.Exception ex, string message)
        {
            //Debug - internal control flow and diagnostic state dumps to facilitate pinpointing of recognised problems
            _logger.Write(LogEventLevel.Debug, ex, message);
        }

        public static void Verbose(System.Exception ex, string message)
        {
            // Verbose - tracing information and debugging minutiae; generally only switched on in unusual situations
            _logger.Write(LogEventLevel.Verbose, ex, message);
        }

        public static void Fatal(System.Exception ex, string message)
        {
            //Fatal - critical errors causing complete failure of the application
            _logger.Write(LogEventLevel.Fatal, ex, message);
        }

        public static void Information(System.Exception ex, string message)
        {
            //Information - critical errors causing complete failure of the application
            _logger.Write(LogEventLevel.Information, ex, message);
        }
    }
}