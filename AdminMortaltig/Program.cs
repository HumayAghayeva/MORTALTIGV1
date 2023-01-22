using Microsoft.EntityFrameworkCore;
using Mortaltig.Infrastructure.Data.Config;
using Mortaltig.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbConn>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn"));
});
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IRoadMapRepository, RoadMapRepository>();
builder.Services.AddScoped<ITeamMembersRepository, TeamMembersRepository>();
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

app.Run();
