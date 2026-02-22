using CleanArchitecture.Application;
using CleanArchitecture.Core;
using CleanArchitecture.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services
    .AddCore()
    .AddApplication(builder.Configuration)
    .AddInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseInfrastructure();

app.MapControllers();

app.Run();