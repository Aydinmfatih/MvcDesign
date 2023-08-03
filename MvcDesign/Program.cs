using FluentValidation.AspNetCore;
using MvcDesign.Constrains;
using MvcDesign.Models;

namespace MvcDesign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Product>());
            builder.Services.Configure<RouteOptions>(options =>  options.ConstraintMap.Add("custom", typeof(CustomConstrain)));
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

            app.MapControllerRoute("Default3", "{controller=Home}/{action=Index}/{id:int?:custom}/{x?}/{y?}");
            app.MapControllerRoute("Default", "anasayfa", new { controller = "Home", action = "Index" });
            

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}