using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc(addJWTBearerAuth: false);

var app = builder.Build();

app.UseFastEndpoints();
app.UseOpenApi();
app.UseSwaggerUi3(x => x.ConfigureDefaults());

app.Run();
