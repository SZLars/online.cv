var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.File(@"C:\Users\lars\source\repos\online.cv\online.cv\wwwroot\htmlpage.html", "text/html"));

app.Run();
