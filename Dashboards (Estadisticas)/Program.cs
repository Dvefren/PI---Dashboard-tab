var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // Cambiamos "/Error" (que busca una Razor Page) por una ruta MVC genérica si llegas a crear un HomeController
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// --- ZONA DE CAMBIOS IMPORTANTES ---

// 1. Eliminamos app.MapRazorPages(); porque ya no usamos esa metodología.

// 2. Agregamos el ruteo MVC.
// Esto le dice a la app: "Al iniciar, busca el DashboardController y muestra la vista Index".
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();