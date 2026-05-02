var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Jonathan Ramiro Elías Vásquez 0907-21-6439!");

app.Run();
