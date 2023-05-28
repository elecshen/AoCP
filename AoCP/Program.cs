using AoCP.Models.DataBaseModel;
using AoCP.Models.Search;
using Microsoft.EntityFrameworkCore;

namespace AoCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            using (ApplicationContext db = new ApplicationContext())
            {
                var Objects = db.Object.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Models.DataBaseModel.Object u in Objects)
                {
                    Console.WriteLine(Search.LevenshteinDistance("tect Asdwdad asdawdasd", u.Name));
                }
            }
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}