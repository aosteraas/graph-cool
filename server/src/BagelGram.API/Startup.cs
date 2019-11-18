using BagelGram.API.Data;
using BagelGram.API.Interfaces;
using BagelGram.API.Query;
using BagelGram.API.Services;
using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BagelGram.API
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
            services.Configure<KestrelServerOptions>(opts =>
            {
                opts.AllowSynchronousIO = true;
            });
            services.AddDbContext<BagelContext>(opts => opts.UseSqlite("Data Source=./Data/BagelGram.db"));

            services.AddControllers();
            services.AddHttpContextAccessor();
            services.AddSingleton<ContextServiceLocator>();

            services.AddSingleton<GraphQL.IDocumentExecuter, GraphQL.DocumentExecuter>();
            services.AddSingleton<GraphQL.Http.IDocumentWriter, GraphQL.Http.DocumentWriter>();
            // consider making these scoped so we dont have to use so
            // many fucking singletons
            services.AddSingleton<PersonQuery>();
            services.AddSingleton<PersonMutation>();
            services.AddSingleton<PersonType>();
            services.AddSingleton<PersonInputType>();
            // services.AddSingleton<Person>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddSingleton<GraphQL.Types.ISchema, PersonSchema>();

            services
                .AddGraphQL(_ =>
                {
                    _.EnableMetrics = true;
                    _.ExposeExceptions = true;
                })
                .AddGraphTypes(ServiceLifetime.Scoped);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseGraphQL<ISchema>();

            app.UseGraphQLPlayground();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
