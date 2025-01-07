var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // bruger static fil

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// Configure the default file to be served
app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "htmlpage.html" }
});

app.Run();
