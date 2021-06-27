using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace hello_world
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
            services.AddRazorPages();
            services.AddSingleton<IHello, Hello>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHello hello)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Map("/test", testPipeline);
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(hello.sayHello());
            });
        }

        private static void testPipeline(IApplicationBuilder app)
        {
            app.MapWhen(context => { return context.Request.Query.ContainsKey("ln"); }, testPipeline1);
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from mapping");
            });
        }

        private static void testPipeline1(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from second mapping");
            });
        }
    }
}
