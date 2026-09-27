using MyApplication.API.Endpoints;
using MyApplication.Application;
using MyApplication.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// OpenAPI / Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Application dependencies
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapAllApplicationEndpoints();
app.Run();