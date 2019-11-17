using GraphiQl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GraphQL;
using GraphQL.Http;
using GraphCool.API.Data;
using Microsoft.EntityFrameworkCore;

namespace GraphCool.API
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
            services.AddDbContext<CoolContext>(opts => opts.UseSqlite("Data Source=Data\\graphcool.db"));

            services.AddControllers();
            services.AddHttpContextAccessor();

            services.AddSingleton<GraphQL.IDocumentExecuter, GraphQL.DocumentExecuter>();
            services.AddSingleton<GraphQL.Http.IDocumentWriter, GraphQL.Http.DocumentWriter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseGraphiQl();
        }
    }
}
