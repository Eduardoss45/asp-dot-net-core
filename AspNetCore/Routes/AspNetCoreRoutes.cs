namespace AspNetCore.Routes;

public static class AspNetCoreRoute
{
    public static void AspNetCoreRoutes(this WebApplication app)
    {
        // Rotas
        app.MapGet("/", () => "Get");
        app.MapPost("/", () => "Post");
        app.MapPut("/", () => "Put");
        app.MapDelete("/", () => "Delete");
        app.MapPatch("/", () => "Patch");
    }
}