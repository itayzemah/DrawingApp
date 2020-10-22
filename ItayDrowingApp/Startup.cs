using DAL;
using DAL.Converters;
using DAL.DALImlementations;
using ItayDrowingApp.AppContracts;
using ItayDrowingApp.Logic.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Oracle.ManagedDataAccess.Client;
using System;
using System.IO;
using Factory;
using System.Net.WebSockets;
using AppContracts.interfaces;
using System.Threading;
using ServiceWebSocket;

namespace ItayDrowingApp
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
            var contentRoot = Configuration.GetValue<string>(WebHostDefaults.ContentRootKey);

            var path = Path.Combine(contentRoot, "dlls");
            var resolver = new Resolver(path, services);
            services.AddSingleton<IResolver>(sp => resolver);


            //services.AddWebSocketManager();

            services.AddControllersWithViews();
            string connectionStringForOracleDB = Configuration.GetConnectionString("OracleDB");
            services.AddSingleton<IDataAccessLayer>(x => new OracleDataAccessLayer(connectionStringForOracleDB));


            services.AddSingleton<IUserDAL, UserDAL>();
            services.AddTransient<UserConverter>();
            //services.AddSingleton<IUserService, UserServiceImple>();

            services.AddSingleton<IDocumentDAL, DocumentDAL>();
            services.AddTransient<DocumentConverter>();
            //services.AddSingleton<IDocumentService, DocumentServiceImple>();

            services.AddSingleton<IWebSocketService, WebSocketServiceImpl>();

            services.AddSingleton<IMarkerDAL, MarkerDAL>();
            services.AddTransient<MarkerConverter>();
            //services.AddSingleton<IMarkerService, MarkerServiceImple>();

            services.AddSingleton<ISharingDAL, SharingDAL>();
            //services.AddSingleton<ISharingService, SharingServiceImple>();


            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
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
            var wsOptions = new WebSocketOptions()
            {
                KeepAliveInterval = TimeSpan.FromSeconds(60),
                ReceiveBufferSize = 4 * 1024
            };

            app.UseWebSockets();
            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/ws")
                {
                    if (context.WebSockets.IsWebSocketRequest)
                    {
                        WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();
                        var wsService = app.ApplicationServices.GetService<IWebSocketService>();
                        var id = context.Request.Query["id"];
                        var userID = context.Request.Query["userID"];
                        wsService.Add(id, userID, webSocket);
                        await webSocket.ReceiveAsync(new Memory<byte>(), CancellationToken.None);


                    }
                    else
                    {
                        context.Response.StatusCode = 400;
                    }
                }
                else
                {
                    await next();
                }
            });
            //app.MapWebSocketManager("/marks", serviceProvider.GetService<DrawAppHandler>());

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
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
