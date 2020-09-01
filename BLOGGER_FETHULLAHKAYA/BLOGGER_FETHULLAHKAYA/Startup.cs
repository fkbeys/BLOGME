using BLOGGER_FETHULLAHKAYA.DATA;
using BLOGGER_FETHULLAHKAYA.DATA.REPO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Reflection;

namespace BLOGGER_FETHULLAHKAYA
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
            //Database connection string
            var connection = @"Server=.;Database=BLOGME;Trusted_Connection=True;ConnectRetryCount=0";

            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(connection));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddControllers();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V1", new Microsoft.OpenApi.Models.OpenApiInfo
                { 
                     
                    Description= "Swagger Example with Repo Pattern",
                   
                    Title= "Swagger Example with Repo Pattern",
                    Version="V1"
                });

                var filename= $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var FilePath = Path.Combine(AppContext.BaseDirectory, filename);

                options.IncludeXmlComments(FilePath);




            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(option=> 
            {
                option.SwaggerEndpoint("/swagger/V1/swagger.json","Swagger Demo API");
                option.RoutePrefix = "";
            } );


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
