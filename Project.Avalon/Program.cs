using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Project.Avalon.Web.Data;
using Project.Avalon.Web.Services.Students;
using MudBlazor.Services;
using Project.Avalon.Shared.DatabaseContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<AllStudentsService>();
builder.Services.AddScoped<SelectedStudentsService>();
builder.Services.AddScoped<SemesterStudentsService>();
builder.Services.AddMudServices();

builder.Services.AddDbContext<StudentsDBContext>(item => item.UseSqlServer("Data Source=KARYA-PC-PRO\\SQLEXPRESS;Initial Catalog=AvalonStudents;Integrated Security=True;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();