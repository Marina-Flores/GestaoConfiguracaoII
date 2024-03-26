using Microsoft.OpenApi.Models;
using ProdutosRestAPI.Interfaces;
using ProdutosRestAPI.Repositories;
using ProdutosRestAPI.Services;

namespace ProdutosRestAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<FilmeService>();
            services.AddSingleton<IFilmeRepository, FilmeRepository>();
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Filmes RestAPI", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if(env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }

            app.UseRouting();

            // Middleware do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Filmes RestAPI");
            });

            app.UseEndpoints(endpoints => endpoints.MapControllers());

        }
    }
}
