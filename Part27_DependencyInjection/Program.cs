using Part27_DependencyInjection;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddTransient<IMessageWriter, ConsoleMessageWriter>();
builder.Services.AddSingleton<IMessageWriter, ConsoleMessageWriter>();
builder.Services.AddTransient<INullInterface, NullClass>();

var host = builder.Build();
host.Run();
