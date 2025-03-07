using AspNetCore.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Configuração de rotas
app.AspNetCoreRoutes();

app.UseHttpsRedirection();
app.Run();