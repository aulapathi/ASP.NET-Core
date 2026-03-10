var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Default HSTS value is 30 days
    app.UseHsts();
}

app.UseHttpsRedirection();

// Serve static files from wwwroot (replace MapStaticAssets)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configure controller routes (replace WithStaticAssets)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
