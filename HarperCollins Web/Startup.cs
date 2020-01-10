using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.MsDependencyInjection;
using HarperCollins.Controllers;
using HarperCollins.Repository;
using HarperCollins.Service;
using HarperCollins.WebApplication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Xml;

namespace HarperCollins_Web
{
    public class Startup
    {
        protected static IWindsorContainer WindsorContainer { get; set; }
        public IConfiguration Configuration { get; }

        private static ILogger Logger { get; set; }

        public Startup(IConfiguration configuration, ILoggerFactory loggerFactory)
        {
            Configuration = configuration;

            // Setup Castle Windsor
            WindsorContainer = new WindsorContainer();

            String ConnectionString = Configuration["ConnectionString:LocalHost"];

            // Read the Log4Net configuration File
            XmlDocument log4netConfig = new XmlDocument();
            log4netConfig.Load("log4net.config");

            // Override the Appender Connection String
            log4netConfig.SelectSingleNode("//connectionString").Attributes["value"].Value = Configuration["ConnectionString:Log4Net"];

            // Register Log4net
            loggerFactory.AddLog4Net(new Microsoft.AspNetCore.Http.HttpContextAccessor(), log4netConfig["log4net"]);

            // Log the Application Start
            Logger = loggerFactory.CreateLogger<Program>();
            Logger.LogInformation("Application Started!");

            // Register Repositories
            WindsorContainer.Register(Component.For<IUnitOfWork>()
                                               .ImplementedBy<UnitOfWork>()
                                               .DependsOn(Dependency.OnValue("ConnectionString", ConnectionString))
                                               //.DependsOn(Dependency.OnValue("Logger", Logger))
                                               .LifestyleCustom<MsScopedLifestyleManager>());

            // Register Services
            WindsorContainer.Register(Component.For<ICustomerDataService>()
                                               .ImplementedBy<CustomerDataService>()
                                               .LifestyleCustom<MsScopedLifestyleManager>());
            WindsorContainer.Register(Component.For<ISalesDataService>()
                                             .ImplementedBy<SalesDataService>()
                                             .LifestyleCustom<MsScopedLifestyleManager>());
            WindsorContainer.Register(Component.For<ITileDataService>()
                                             .ImplementedBy<TileDataService>()
                                             .LifestyleCustom<MsScopedLifestyleManager>());


            // Register controllers
            WindsorContainer.Register(Component.For<CustomerDataController>()
                                                           .LifestyleCustom<MsScopedLifestyleManager>());
            WindsorContainer.Register(Component.For<SalesDataController>()
                                               .LifestyleCustom<MsScopedLifestyleManager>());
            WindsorContainer.Register(Component.For<TileDataController>()
                                                           .LifestyleCustom<MsScopedLifestyleManager>());

        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddCastleControllerActivator(WindsorContainer);

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
