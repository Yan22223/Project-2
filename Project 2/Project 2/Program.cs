var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Serve index.html as default and enable /wwwroot static files
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();