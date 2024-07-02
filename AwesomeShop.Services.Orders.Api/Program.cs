using AwesomeShop.Services.Orders.Application;
using AwesomeShop.Services.Orders.Infrastructure;
using Consul;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddHttpClient();
builder.Services
        .AddRedisCache()
        .AddMessageBus()
        .AddMongo()
        .AddRepositories()
        .AddHandlers()
        .AddSubscribers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseConsul();

app.MapControllers();

app.Run();
