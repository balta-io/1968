using DomainNotificationSample.Data.Contexts;
using DomainNotificationSample.Data.Repositories;
using DomainNotificationSample.Data.Transaction;
using DomainNotificationSample.Domain.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DomainNotificationSample.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<DnDataContext, DnDataContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserRepository, UserRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();
        }
    }
}