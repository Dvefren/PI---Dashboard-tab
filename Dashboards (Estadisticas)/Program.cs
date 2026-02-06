using Dashboards.Services; // <--- Asegúrate de tener este using

var builder = WebApplication.CreateBuilder(args); // 1. PRIMERO SE CREA EL BUILDER

// 2. LUEGO SE AGREGAN LOS SERVICIOS (Aquí va la línea que daba error)
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DashboardService>(); // <--- Esta línea debe ir DESPUÉS de crear el builder

var app = builder.Build(); // 3. FINALMENTE SE CONSTRUYE LA APP

// ... El resto de tu configuración de pipeline ...
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();