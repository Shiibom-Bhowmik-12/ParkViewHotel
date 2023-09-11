using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Parkview.Models;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddScoped<IDestinationRepo, DestinationDbRepo>();
builder.Services.AddScoped<IHotelChainRepo, HotelChainDbRepo>();
builder.Services.AddScoped<IHotelRepo, HotelDbRepo>();
builder.Services.AddScoped<IRoomRepo, RoomDbRepo>();
builder.Services.AddScoped<IBookingRepo, BookingRepo>();
builder.Services.AddDbContext<ParkviewDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<ParkviewDbContext>();
builder.Services.AddAuthentication().AddGoogle(options =>
{
    options.ClientId = builder.Configuration["Authentication:Google:ClientId"];
    options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
});

builder.Services.AddAuthentication().AddFacebook(options =>
{
    options.ClientId = builder.Configuration["Authentication:Facebook:ClientId"];
    options.ClientSecret = builder.Configuration["Authentication:Facebook:ClientSecret"];
});

var app = builder.Build();
app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseStaticFiles();
StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();


app.Run();
