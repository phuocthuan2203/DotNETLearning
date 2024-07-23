using Microsoft.Extensions.Logging;

namespace Part24_Logging;

class Program
{
    static void Main(string[] args)
    {

        using ILoggerFactory factory = LoggerFactory.Create(
            builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Information);
            }
        );
        ILogger logger = factory.CreateLogger("Program");
        logger.LogTrace("LogTrace");
        logger.LogDebug("LogDebug");
        logger.LogInformation("LogInformation");
        logger.LogWarning("LogWarning");
        logger.LogError("LogError");
        logger.LogCritical("LogCritical");

        if (logger.IsEnabled(LogLevel.Debug))
        {
            var cart = GetCart();
            
            logger.LogDebug("cart info: {cart}", cart);
        }
    }

    private static object?[] GetCart()
    {
        throw new NotImplementedException();
    }
}