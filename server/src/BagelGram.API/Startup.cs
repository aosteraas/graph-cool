using BagelGram.Data;
using BagelGram.API.Services;
using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BagelGram.Core.Interfaces;
using BagelGram.Data.Repositories;
using Microsoft.Extensions.FileProviders;
using System.IO;
using BagelGram.API.Query.Queries;
using BagelGram.API.Query.Mutations;
using BagelGram.API.Query.Types;
using BagelGram.API.Query.Schemas;
using BagelGram.API.Query.Inputs;
using GraphQL;

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

            services.AddDbContext<BagelContext>(opts => opts.UseSqlite("Data Source=../BagelGram.Data/Data/BagelGram.db"));

            services.AddControllers();
            services.AddHttpContextAccessor();
            // I don't like the ramifications of using singletons in DI but or
            // at all but there doesn't seem to be any feasible alternative in
            // .NET right now.
            services.AddSingleton<ContextServiceLocator>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            // Root Schema types
            services.AddSingleton<BagelQuery>();
            services.AddSingleton<BagelMutation>();

            // Users
            services.AddSingleton<UserQuery>();
            services.AddSingleton<UserType>();
            services.AddSingleton<UserInputType>();

            // Images
            services.AddSingleton<ImageQuery>();
            services.AddSingleton<ImageType>();
            services.AddSingleton<ImageInputType>();

            // Comments
            services.AddSingleton<CommentQuery>();
            services.AddSingleton<CommentType>();
            services.AddSingleton<CommentInputType>();

            // Likes
            services.AddSingleton<LikeType>();

            // Repositories
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IImageRepository, ImageRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<ILikeRepository, LikeRepository>();

            services.AddSingleton<ISchema, BagelSchema>();

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

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "uploads")),
                RequestPath = "/uploads"
            });

            // app.UseHttpsRedirection();

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
