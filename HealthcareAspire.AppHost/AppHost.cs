var builder = DistributedApplication.CreateBuilder(args);

// PostgreSQL server
var postgres = builder.AddPostgres("pg");
// Databases for each service
var patientsDb = postgres.AddDatabase("patientsdb");
var appointmentsDb = postgres.AddDatabase("appointmentsdb");

var patients = builder.AddProject<Projects.HealthcareAspire_PatientsApi>("patientsapi");
var appointments = builder.AddProject<Projects.HealthcareAspire_AppointmentsApi>("appointmentsapi");

builder.Build().Run();
