using Thoughtful.Api.Extensions;
using Thoughtful.Dal;
using Thoughtful.Domain.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationServices(builder.Configuration);
builder.RegisterModules();

var app = builder.Build();
app.ConfigureApplication();
app.MapEndpoints();

app.Run();

