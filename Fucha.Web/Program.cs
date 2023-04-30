using AutoMapper;
using Fucha.DataLayer.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//var serverVersion = new MySqlServerVersion(new Version(8, 0, 30));

builder.Services.AddDbContext<FuchaMilkteaContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("AzureConnectionString")));
    //options.UseMySql(builder.Configuration.GetConnectionString("MySQLServerConnectionString"), serverVersion));
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnectionString")));

builder.Services.AddScoped(typeof(IFuchaMilkteaContext), typeof(FuchaMilkteaContext));

builder.Services.AddMediatR(typeof(FuchaMilkteaContext));

builder.Services.AddAutoMapper(configAction => { configAction.ValidateInlineMaps = false; }, typeof(Fucha.Application.Response));

// Add services to the container.
builder.Services.AddControllers();

var corsOptions = new CorsOptions();
builder.Configuration.GetSection("Cors").Bind(corsOptions);

builder.Services.AddCors(options =>
{
    options.AddPolicy("default", policy => policy
        .WithOrigins(corsOptions.AllowedOrigins.ToArray())
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
        );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("default");

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class CorsOptions
{
    public List<string> AllowedOrigins { get; set; }
}