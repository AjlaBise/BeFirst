using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BeFirst.WebAPI.Database;
using BeFirst.WebAPI.Filters;
using BeFirst.WebAPI.Security;
using BeFirst.WebAPI.Services;
using BeFirst.WebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BeFirst.WebAPI
{

    public class AuthOperationFilter : Swashbuckle.AspNetCore.SwaggerGen.IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var isAuthorized = context.MethodInfo.DeclaringType.GetCustomAttributes(true).OfType<AuthorizeAttribute>().Any() ||
                               context.MethodInfo.GetCustomAttributes(true).OfType<AuthorizeAttribute>().Any();
            if (!isAuthorized) return;
            operation.Responses.TryAdd("401", new OpenApiResponse { Description = "Unauthorized" });
            operation.Responses.TryAdd("403", new OpenApiResponse { Description = "Forbidden" });
            var basicSecurityScheme = new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basic" },
            };
            operation.Security.Add(new OpenApiSecurityRequirement()
            {
                [basicSecurityScheme] = new string[] { }
            });
        }
    }

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
            services.AddControllers();

            services.AddDbContext<BeFirstContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("connectionpc")));

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>
                    ("BasicAuthentication", null);

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .ConfigureApiBehaviorOptions(options =>
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        var problems = new ValidateFilter(context);
                        return new BadRequestObjectResult(problems);
                    };
                });

            services.Configure<ApiBehaviorOptions>(a =>
            {
                a.InvalidModelStateResponseFactory = context =>
                {
                    var problemDetails = new ValidateFilter(context);
                    return new BadRequestObjectResult(problemDetails)
                    {
                        ContentTypes = { "application / problem + json", "application / problem + xml" }
                    };
                };
            });

            services.AddScoped<IUgovorService, UgovorService>();
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IPonudaService, PonudaService>();
            services.AddScoped<IUposlenikService, UposlenikService>();
            services.AddScoped<IInternetService, InternetService>();
            services.AddScoped<IPaketService, PaketService>();
            services.AddScoped<IPozicijeService, PozicijaService>();
            services.AddScoped<IOpremaServices, OpremaServices>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IZahjtevService, ZahjtevService>();
            services.AddScoped<IRadniNalogService, RadniNalogService>();
            services.AddScoped<IReportService, ReportRadniNalogService>();
            services.AddScoped<IRecommenderService, RecommenderService>();
            services.AddScoped<IOpremaUposlenikRadniNalogService, OpremaUposlenikRadniNalogService>();
            services.AddScoped<IVrstaPaketaServiices, VrstaPaketaServices>();

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic",
                    new OpenApiSecurityScheme()
                    {
                        Name = "Authorization",
                        Type = SecuritySchemeType.Http,
                        Scheme = "basic",
                        In = ParameterLocation.Header,
                        Description = "Basic authentication header"
                    });
                c.OperationFilter<AuthOperationFilter>();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "MyAPI V1");

            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}