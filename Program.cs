
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Home endpoint
app.MapGet("/", () => "Hello from my C# server!");

// Health-check endpoint
app.MapGet("/health", () =>
    Results.Ok(new
    {
        status = "running"
    }));

// API endpoint returning JSON
app.MapGet("/api/student", () =>
    Results.Ok(new
    {
        project = "My First C# Server",
        language = "C#",
        grade = 12,
        message = "My API works!"
    }));

app.Run();
