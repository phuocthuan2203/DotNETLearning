namespace Part27_DependencyInjection;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IMessageWriter _messageWriter;
    private readonly IServiceProvider _services;

    public Worker(ILogger<Worker> logger, IMessageWriter messageWriter, IServiceProvider services)
    {
        _logger = logger;
        _messageWriter = messageWriter;
        _services = services;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var m1 = _services.GetService<IMessageWriter>();
        
        while (!stoppingToken.IsCancellationRequested)
        {
            _messageWriter.Write($"Current day: {DateTime.Now}");
            
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }
            await Task.Delay(9000, stoppingToken);
        }
    }
}
