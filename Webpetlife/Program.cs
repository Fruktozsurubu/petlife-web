global using Microsoft.EntityFrameworkCore;
global using Webpetlife.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<DataContext>();

// Enable CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});
var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
// Enable CORS
app.UseCors("AllowAllOrigins");
app.MapControllers();
app.UseStaticFiles();
app.MapRazorPages();
// Login sayfasýný ana sayfa olarak belirleme
app.MapFallbackToPage("/Login");

app.Run();







