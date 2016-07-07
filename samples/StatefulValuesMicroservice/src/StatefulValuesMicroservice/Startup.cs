using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StatefulValuesMicroservice.Data;
using Microsoft.EntityFrameworkCore;

namespace StatefulValuesMicroservice
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            // Setup DB
            string dbName = Environment.GetEnvironmentVariable("POSTGRES_DB") ?? "192.168.99.100";
            string dbPassword = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD") ?? "postgres";
            string pgConStr = string.Format("Host={0};Port=5432;Database=myDataBase;User ID=postgres;Password={1}", dbName, dbPassword);
            services.AddDbContext<StoredValuesContext>(options => options.UseNpgsql(pgConStr));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();

            // Create DB on startup
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<StoredValuesContext>().Database.Migrate();
            }
        }
    }
}
