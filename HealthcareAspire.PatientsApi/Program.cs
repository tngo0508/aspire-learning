var builder = WebApplication.CreateBuilder(args);
builder.AddServiceDefaults();
var app = builder.Build();
app.MapGet("/patients", () => Results.Ok(new[] { new { id = 123, name = "Jane Doe" } }))
    .WithName("GetPatients");
app.MapDefaultEndpoints();
app.Run();
