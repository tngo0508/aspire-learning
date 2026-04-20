var builder = DistributedApplication.CreateBuilder(args);

var patients = builder.AddProject<Projects.HealthcareAspire_PatientsApi>("patientsapi");
var appointments = builder.AddProject<Projects.HealthcareAspire_AppointmentsApi>("appointmentsapi");

builder.Build().Run();
