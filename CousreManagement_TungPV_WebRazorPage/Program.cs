using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<CousreManagementContext>(
        options => options.UseSqlServer("name=ConnectionStrings:CousreManagementDB"));
builder.Services.AddScoped<SemeterRepository>();
builder.Services.AddScoped<MajorRepository>();
builder.Services.AddScoped<SubjectRepository>();
builder.Services.AddScoped<InstructorRepository>();
builder.Services.AddScoped<StudentRepository>();
builder.Services.AddScoped<CourseRepository>();
builder.Services.AddScoped<EnrollmentRepository>();
builder.Services.AddScoped<SectionRepository>();
builder.Services.AddScoped<AttendanceRepository>();


builder.Services.AddSession();
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

app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
