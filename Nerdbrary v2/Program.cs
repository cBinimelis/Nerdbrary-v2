using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NerdClassLibrary.DbAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<BdBibliotecaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<IAnimeData, AnimeData>();
builder.Services.AddScoped<IGeneroAnimeData, GeneroAnimeData>();
builder.Services.AddScoped<IMangaData, MangaData>();
builder.Services.AddScoped<IGeneroMangaData, GeneroMangaData>();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
builder.Services.AddSingleton<IUsuarioData, UsuarioData>();
//http Client
builder.Services.AddHttpClient();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapBlazorHub();
    endpoints.MapRazorPages();
    endpoints.MapFallbackToPage("/_Host");
});


app.Run();
