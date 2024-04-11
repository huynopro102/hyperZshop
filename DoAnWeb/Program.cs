using DoAnWeb.Model;
using DoAnWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddControllersWithViews();
// Add DbContext
builder.Services.AddDbContext<CsdlwebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Identity
//builder.Services.AddIdentity<CsdlwebContext, IdentityRole>().AddDefaultTokenProviders().AddDefaultUI().AddEntityFrameworkStores<ApplicationDbContext>();

// Configure Application Cookie
/*builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout"; // Change from LoginPath to LogoutPath
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied"; // Correct typo in path
});
*/
// Add Razor Pages
builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<IProductTypeRepository, EFProductTypeRepository>();
builder.Services.AddScoped<ISupplierRepository, EFSupplierRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllerRoute(
    name: "Admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"); // Correct typo in the area constraint

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();