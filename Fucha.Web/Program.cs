using Fucha.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using MediatR;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

var serverVersion = new MySqlServerVersion(new Version(8, 0, 30));

/* PostgreSql Connection */
builder.Services.AddDbContext<FuchaMilkteaContext>(options =>
    //options.UseSqlServer(builder.Configuration.GetConnectionString("AzureConnectionString")));

    options.UseMySql(builder.Configuration.GetConnectionString("MySQLServerConnectionString"), serverVersion));
    //options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnectionString"))); 


//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("Policy1",
//        policy =>
//        {
//            policy.WithOrigins("http://example.com",
//                                "http://www.contoso.com");
//        });

//    options.AddPolicy("AnotherPolicy",
//        policy =>
//        {
//            policy.WithOrigins("https://localhost:7280")
//                                .AllowAnyHeader()
//                                .AllowAnyMethod();
//        });

//    //options.AddDefaultPolicy(
//    //    policy =>
//    //    {
//    //        policy.WithOrigins("http://example.com",
//    //                            "http://www.contoso.com");
//    //    });
//});

builder.Services.AddScoped(typeof(IFuchaMilkteaContext), typeof(FuchaMilkteaContext));
//builder.Services.AddMediatR(typeof(GetUsersQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(FuchaMilkteaContext));


builder.Services.AddAutoMapper(configAction => { configAction.ValidateInlineMaps = false; }, typeof(Fucha.Application.Response));
//builder.Services.AddAutoMapper(typeof())
// Add services to the container.
builder.Services.AddControllers();
//builder.Services.AddRazorPages();


var corsOptions = new CorsOptions();
builder.Configuration.GetSection("Cors").Bind(corsOptions);

builder.Services.AddCors(options =>
{
    options.AddPolicy("default", policy => policy
        .WithOrigins(corsOptions.AllowedOrigins.ToArray())
        .AllowAnyHeader()
        .AllowAnyMethod()
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

//app.UseCors(options =>
//    options.WithOrigins("http://localhost:8080")
//    .AllowAnyMethod()
//    .AllowAnyHeader());


app.UseAuthorization();

//app.MapRazorPages();
app.MapControllers();

app.Run();


public class CorsOptions
{
    public List<string> AllowedOrigins { get; set; }
}

