using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NETCoreHelloWorldWebApi.Infrastructure.Container;
using NETCoreHelloWorldWebApi.Mapping;
using NETCoreHelloWorldWebApi.Persistence.Mapping;
using Swashbuckle.AspNetCore.Swagger;

namespace NETCoreHelloWorldWebApi
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
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "My API",
                    Description = "My ASP.NET Core Web API Demo",
                    TermsOfService = "None",
                    Contact = new Contact { Name = "Benjamin Bagley", Email = "benhbagley@gmail.com" }
                });
            });

            PersistenceModule.Configure(services);
            ServicesModule.Configure(services);

            Mapper.Initialize(x =>
            {
                x.AddProfile(new WebMappingProfile());
                x.AddProfile(new PersistenceMappingProfile());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
