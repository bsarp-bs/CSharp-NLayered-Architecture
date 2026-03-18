using BusinessLayer.Abstract_Services_;
using BusinessLayer.Concrete_Manager;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete_DAL.EntityFramework;
using DataAccessLayer.DAL_Context;
using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IServiceService, ServiceManager>();
builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();

builder.Services.AddScoped<IStaffService, StaffManager>();
builder.Services.AddScoped<IStaffDAL, EFStaffDAL>();

builder.Services.AddScoped<ICommunicationService, CommunicationManager>();
builder.Services.AddScoped<ICommunicationDAL, EFCommunicationDAL>();

builder.Services.AddScoped<IJournalService, JournalManager>();
builder.Services.AddScoped<IJournalDAL, EFJournalDAL>();

builder.Services.AddScoped<IImagesService, ImageManager>();
builder.Services.AddScoped<IImagesDAL, EFImagesDAL>();

builder.Services.AddScoped<ILocationService, LocationManager>();
builder.Services.AddScoped<ILocationDAL, EFLocationDAL>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDAL, EFSocialMediaDAL>();

builder.Services.AddDbContext<Context>();

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();

builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
    {
        x.LoginPath = "/Login/LoginIndex";
    });

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<Context>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseAuthentication();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=HomeIndex}/{id?}")
    .WithStaticAssets();


app.Run();
