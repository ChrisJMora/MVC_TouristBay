using MVC_TouristBay.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();  //Añadido
// Utils
ListaSucursales.Instancia();
ListaCiudades.Instancia();
ListaHoteles.Instancia();
ListaTuristas.Instancia();
ListaUsuarios.Instancia();
ListaAerolineas.Instancia();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();   //Añadido

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
