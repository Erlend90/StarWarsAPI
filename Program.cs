var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//add routing here to get specific planet
//like "/planet/{id}"

app.Run();