using Microsoft.EntityFrameworkCore;
using Prueba2.Datos;

var builder = WebApplication.CreateBuilder(args);

//Configuramos la conexión a SQL Server local DB MSSQLLOCAL
builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Inicio/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Inicio}/{action=Index}/{id?}");

app.Run();
