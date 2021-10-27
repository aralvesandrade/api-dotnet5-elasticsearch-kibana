using ApiElasticSearch.Core.Extensions;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiElasticSearch
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiConfiguration();

            services.AddElasticsearch(Configuration);
            services.AddSwagger(Configuration);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseApiConfiguration(env);
            
            app.UseSwaggerDoc();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                // endpoints.MapHealthChecks("/hc",
                //     new HealthCheckOptions
                //     {
                //         Predicate = _ => true,
                //         ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
                //     });
            });
        }
    }
}