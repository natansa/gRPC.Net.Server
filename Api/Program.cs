using Api.Services;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddGrpc();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(7192, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http2;
    });
});

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();
app.MapOpenApi();
app.UseAuthorization();
app.MapControllers();
app.MapGrpcService<PersonServiceImpl>();
app.MapGet("/", () => "gRPC Server rodando...");

await app.RunAsync();