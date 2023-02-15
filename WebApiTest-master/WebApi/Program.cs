using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WebApi.Models;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddDbContext<SampleDBContext>();

//var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

////builder.Services.AddCors(options =>
////{
////    options.AddDefaultPolicy(
////        builder =>
////        {
////            builder.WithOrigins("https://localhost:44351", "http://localhost:4200")
////                                .AllowAnyHeader()
////                                .AllowAnyMethod();
////        });
////});

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: MyAllowSpecificOrigins,
//                      builder =>
//                      {
//                          builder.WithOrigins("http://localhost:4200",
//                                              "https://localhost:4200")
//                            .AllowAnyHeader()
//                                .AllowAnyMethod();
//                      });
//});
//var app = builder.Build();
//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{

//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
//app.UseCors(MyAllowSpecificOrigins);

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
