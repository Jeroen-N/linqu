using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using linqu.profileservice.Interfaces;
using linqu.profileservice.Services;
using linqu.profileservice.Repositories;

namespace linqu.profileservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //dependency injection
            services.AddTransient<IProfileService, ProfileService>();
            services.AddTransient<IQuestionService, QuestionService>();
            services.AddTransient<IQuestionRepository, QuestionRepository>();
            services.AddTransient<IProfileRepository, ProfileRepository>();
            services.AddTransient<IAnswerService, AnswerService>();
        }

        // This method gets called by the runtime. Use this method to configure the HT-TP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
