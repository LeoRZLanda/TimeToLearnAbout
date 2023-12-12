using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using DarkShop.Ecommerce.Transversal.Mapper;
using DarkShop.Ecommerce.Transversal.Common;
using DarkShop.Ecommerce.Infrastructure.Data;
using DarkShop.Ecommerce.Infrastructure.Repository;
using DarkShop.Ecommerce.Infrastructure.Interface;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Domain.Core;
using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Application.Main;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;


namespace DarkShop.Ecommerce.Services.WebApi
{
    public class Startup

    {

        readonly string myPolicy = "policyApiEcommerce";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));

            services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(Configuration["Config:OriginCors"])
                                                                                        .AllowAnyHeader()
                                                                                        .AllowAnyMethod()
            ));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => { options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver(); });

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddScoped<ICustomersDomain, CustomersDomain>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();

            //Register the swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "DarkShop Technology Services API Market",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "LeoRZLanda",
                        Email = "LeoRZLanda@gmail.com",
                        Url = "https://darkshop.com"
                    },
                    License = new License
                    {
                        Name = "Use under LICK",
                        Url = "https://example.com/license"
                    }
                });
                //Set the comments path for the Swagger JSON and UI
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Enable midleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();

            //Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            // Specigying the Swagger JSON endpoint
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API Ecomerce V1");
            });

            app.UseCors(myPolicy);

            app.UseMvc();
        }
    }
}
