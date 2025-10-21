using CMSFinalProject.Services;

namespace CMSFinalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<Repositories.ILoginRepo, Repositories.LoginRepoImpl>();
            builder.Services.AddScoped<Services.ILoginService, Services.LoginServiceImpl>();
            builder.Services.AddScoped<Repositories.IPatientRepo, Repositories.PatientRepoImpl>();
            builder.Services.AddScoped<Services.IPatient, Services.PatientServiceImpl>();
            builder.Services.AddScoped<IAdminService, AdminServiceImpl>();
            builder.Services.AddScoped<Repositories.IAdminRepo, Repositories.AdminRepoImpl>();


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
        }
    }
}
