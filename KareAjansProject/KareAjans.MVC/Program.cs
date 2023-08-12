using KareAjans.BLL.Abstract;
using KareAjans.BLL.AbstractService;
using KareAjans.BLL.Concrete;
using KareAjans.BLL.Service;
using KareAjans.DAL.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using KareAjans.IOC.Container;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Services

//Veritabanýný servicelere ekleme
builder.Services.AddDbContext<KareAjansContext>();
    //(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));//appsettings de tanýmladýðýmýz connectionstring


//Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<KareAjansContext>();

//Login
builder.Services.ConfigureApplicationCookie(options =>
{
    // Diðer yapýlandýrmalar
    options.LoginPath = new PathString("/Home/Login");
    options.AccessDeniedPath = new PathString("/Home/Login");
    options.Cookie.Name = "loginCookie";
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

});





//Session
builder.Services.AddSession(x =>
{
    x.Cookie.Name = "organizasyon";
    x.IdleTimeout = TimeSpan.FromMinutes(1);
});

//Kullandýðýmýz servisleri IOC katmanýnda tanýmladýk ve baðlantýsýný gerçekleþtirdik
ServiceContainer.ServiceConfigure(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseSession();
app.UseEndpoints(endpoints =>
{
    //Admin

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    //Default
    endpoints.MapDefaultControllerRoute();

    
});

app.Run();
