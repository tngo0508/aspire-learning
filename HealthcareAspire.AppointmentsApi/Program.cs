var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

var app = builder.Build();

app.MapGet("/appointments", () => Results.Ok(new[] { new { id = 1, date = DateTime.UtcNow, patientId = 123 } }))
    .WithName("GetAppointments");

app.MapDefaultEndpoints();
app.Run();
