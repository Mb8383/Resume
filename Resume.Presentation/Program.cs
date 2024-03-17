using Resume.Application.Services.Implement;
using Resume.Application.Services.Interface;
using Resume.Domain.RepositoryInterface;
using Resume.Infrastructure.Repository;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<RsumeDbContext>();
            #region Repository
            builder.Services.AddScoped<IEducationRepository, EducationRepository>();
            builder.Services.AddScoped<IExperinceRepository, ExperinceRepository>();
            builder.Services.AddScoped<IMySkillsRepository, MySkillsRepository>();
            builder.Services.AddScoped<IContactRepository, ContactRepository>();
            #endregion

            #region Services

            builder.Services.AddScoped<IContactService,ContactService>();
            builder.Services.AddScoped<IExperienceService,ExperienceService>();
            builder.Services.AddScoped<IMySkillsService,MySkillsService>();
            builder.Services.AddScoped<IEducationService,EducationService>();
            #endregion

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
