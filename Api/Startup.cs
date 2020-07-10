using Api.Entities;
using Api.Helpers;
using Api.Middlewares;
using Api.Services;
using Api.Settings;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Identity
            services.AddDbContext<Api.Identity.SecurityContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            // Tools->NuGet Package Manager -> Package Manager Console
            // Initialise
            // add-migration init -Context SecurityContext
            // update or create DB
            // update-database -Context SecurityContext
            IdentityHelper.ConfigureService(services);

            // Helpers
            AuthenticationHelper.ConfigureService(services, Configuration["JwtSecurityToken:Issuer"], Configuration["JwtSecurityToken:Audience"], Configuration["JwtSecurityToken:Key"]);
            CorsHelper.ConfigureService(services);
            SwaggerHelper.ConfigureService(services);

            // Settings
            services.Configure<EmailSettings>(Configuration.GetSection("Email"));
            services.Configure<ClientAppSettings>(Configuration.GetSection("ClientApp"));
            services.Configure<JwtSecurityTokenSettings>(Configuration.GetSection("JwtSecurityToken"));
            //services.Configure<QRCodeSettings>(Configuration.GetSection("QRCode"));

            // Services
            services.AddTransient<IEmailService, EmailService>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddControllers();

            // Mapper
            services.AddAutoMapper(typeof(AutoMapping));

            //Define upload
            services.Configure<FormOptions>(o => {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseErrorHandlingMiddleware();
            // Use WhiteList
            // app.UseWhiteListMiddleware(Configuration["AllowedIPs"]);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");
            app.UseAuthentication();
            app.UseAuthorization();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web API V1");
                c.RoutePrefix = "";
            });

            //Static file
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Resources")),
                RequestPath = new PathString("/Resources")
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
