


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "ji World!");

app.Run();
Console.WriteLine("tuan anh");
