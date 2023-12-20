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
using DarkShop.Ecommerce.Transversal.Logging;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;
using DarkShop.Ecommerce.Services.WebApi.Helpers;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Hosting;

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
            //NET 2.2 services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));

            //NET 3.0
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingsProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(Configuration["Config:OriginCors"])
                                                                                        .AllowAnyHeader()
                                                                                        .AllowAnyMethod()
            ));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            var appSettingsSection = Configuration.GetSection("Config");
            services.Configure<AppSettings>(appSettingsSection);

            //configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddScoped<ICustomersDomain, CustomersDomain>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
            services.AddScoped<IUserApplication, UserApplication>();
            services.AddScoped<IUserDomain, UserDomain>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var Issuer = appSettings.Issuer;
            var Audience = appSettings.Audience;

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x => {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var userId = int.Parse(context.Principal.Identity.Name);
                        return Task.CompletedTask;
                    },

                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = false;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = Issuer,
                    ValidateAudience = true,
                    ValidAudience = Audience,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });

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

                c.AddSecurityDefinition("Authorization", new ApiKeyScheme{
                    Description = "Authorization by API Key",
                    In = "header",
                    Type = "apiKey",
                    Name = "Authorization"
                });

                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    {"Authorization", new string[0]}
                });
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

            //Enable midleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();

            //Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            // Specigying the Swagger JSON endpoint
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API Ecomerce V1");
            });

            app.UseCors(myPolicy);
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            //app.UseMvc();
        }
    }
}
