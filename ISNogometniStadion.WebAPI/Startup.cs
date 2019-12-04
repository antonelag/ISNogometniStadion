using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using AutoMapper;
using ISNogometniStadion.Model;
using ISNogometniStadion.Model.Requests;
using ISNogometniStadion.WebAPI.Database;
using ISNogometniStadion.WebAPI.Filters;
using ISNogometniStadion.WebAPI.Security;
using ISNogometniStadion.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
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
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ISNogometniStadion.WebAPI
{
    public class BasicAuthDocumentFilter : IDocumentFilter
    {
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            var securityRequirements = new Dictionary<string, IEnumerable<string>>()
        {
            { "basic", new string[] { } }  // in swagger you specify empty list unless using OAuth2 scopes
        };

            swaggerDoc.Security = new[] { securityRequirements };
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
            //da jedan od filtera treba da se doda i error filter koji je implementiran da mozemo da kontrolisemo
            //kako cemo prikazati gresku
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //dok traje sam request, instanca servisa ce trajati dok traje req
            //dependencyInjection
            services.AddAutoMapper((typeof(Startup)));





            services.AddAuthentication("BasicAuthentication")
             .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new BasicAuthScheme() { Type = "basic" });
                c.DocumentFilter<BasicAuthDocumentFilter>();
            });








            services.AddScoped<ICRUDService<Model.Ulaznica, UlazniceSearchRequest, UlazniceInsertRequest, UlazniceInsertRequest>, UlazniceService>();
            services.AddScoped<ICRUDService<Model.Liga, LigaSearchRequest, LigaInsertRequest, LigaInsertRequest>, LigeService>();
            //jer ulazniceservice implementira search
            services.AddScoped<ICRUDService<Model.Drzava, DrzaveSearchRequest, DrzaveInsertRequest, DrzaveInsertRequest>, DrzaveService>();
            services.AddScoped<ICRUDService<Model.Grad, GradoviSearchRequest, GradoviInsertRequest, GradoviInsertRequest>, GradService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Model.Tim, TimoviSearchRequest, TimoviInsertRequest, TimoviInsertRequest>, TimoviService>();
            services.AddScoped<ICRUDService<Model.Stadion, StadioniSearchRequest, StadioniInsertRequest, StadioniInsertRequest>, StadioniService>();
            services.AddScoped<ICRUDService<Model.Tribina, TribineSearchRequest, TribineInsertRequest, TribineInsertRequest>, TribineService>();
            services.AddScoped<ICRUDService<Model.Sektor, SektoriSearchRequest, SektoriInsertRequest, SektoriInsertRequest>, SektoriService>();
            services.AddScoped<ICRUDService<Model.Sjedalo, SjedalaSearchRequest, SjedalaInsertRequest, SjedalaInsertRequest>, SjedalaService>();
            services.AddScoped<ICRUDService<Model.Utakmica, UtakmiceeSearchRequest, UtakmiceInsertRequest, UtakmiceInsertRequest>, UtakmiceService>();
            services.AddScoped<ICRUDService<Model.Preporuka, PreporukaSearchRequest, PreporukaInsertRequest, PreporukaInsertRequest>, PreporukeService>();
            services.AddScoped<ICRUDService<Model.Uplata, UplateSearchRequest, UplateInsertRequest, UplateInsertRequest>, UplateService>();
            services.AddScoped<ICRUDService<Model.PreporukaPoLokaciji, PreporukaSearchRequest, PreporukePoLokacijiInsertRequest, PreporukePoLokacijiInsertRequest>, PreporukePoLokacijiService>();
            services.AddScoped<ICRUDService<Model.PreporukaPoStadionu, PreporukaSearchRequest, PreporukePoStadionuInsertRequest, PreporukePoStadionuInsertRequest>, PreporukePoStadionuService>();
            services.AddScoped<ICRUDService<Model.PreporukaPoTimu, PreporukaSearchRequest, PreporukePoTimuInsertRequest, PreporukePoTimuInsertRequest>, PreporukePoTimuService>();

            //za registraciju
            services.AddScoped<GradService, GradService>();
            services.AddScoped<DrzaveService, DrzaveService>();


            var conn = @"data source=.;initial catalog=160125; integrated security = True; ";
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

            app.UseSwagger();



            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");

            });

            app.UseAuthentication();
            //app.UseHttpsRedirection(); //ukoliko smo dosli na api bez https automatski ce .netcore sve prebaciti na https
            app.UseMvc();
        }
    }
}
