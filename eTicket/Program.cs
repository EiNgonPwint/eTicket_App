using eTicket.Data;
using eTicket.Data.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//DbContext configuration
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration
.GetConnectionString("DefaultConnectionString")));

//Services configuration

builder.Services.AddScoped<IActorsService,ActorService>();

builder.Services.AddScoped<IProducerService,ProducerService>();

builder.Services.AddScoped<ICinemaService, CinemaService>();

builder.Services.AddScoped<IMoviesService, MoviesService>();
// Add services to the container.
builder.Services.AddControllersWithViews();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//seed Database
AppDbInitializercs.seed(app);

app.Run();

