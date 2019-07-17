using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Filters;
using ISNogometniStadion.WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace ISNogometniStadion.WebAPI
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
            //da jedan od filtera treba da se doda i error filter koji je implementiran da mozemo da kontrolisemo
            //kako cemo prikazati gresku
            services.AddMvc(x=>x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                
            });
            //dok traje sam request, instanca servisa ce trajati dok traje req
            //dependencyInjection
            services.AddAutoMapper((typeof(Startup)));
            services.AddScoped<IUlaznicaService, UlaznicaService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IDrzaveService, DrzaveService>();
            services.AddScoped<IGradoviService, GradoviService>();
            services.AddScoped<ITimoviService, TimoviService>();
            services.AddScoped<IStadioniService, StadioniService>();
            services.AddScoped<ITribineService, TribineService>();

            var conn = @"Server = (localdb); Database = ISNogometniStadionDB; Trusted_Connection = True; ";
            services.AddDbContext<ISNogometniStadionContext>(options => options.UseSqlServer(conn));
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
          
            

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                
            });
        }
    }
}
