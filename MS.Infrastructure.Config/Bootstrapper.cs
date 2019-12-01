using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MS.Application;
using MS.Application.Contracts.Contracts;
using MS.Domain;
using MS.Infrastructure.Persistance;
using MS.Infrastructure.Persistance.Repositories;

namespace MS.Infrastructure.Config
{
    public static class Bootstrapper
    {
        public static void Config(IServiceCollection services, string connectionString)
        {
            services.AddScoped<IMailApplication, MailApplication>();
            services.AddScoped<IMailRepository, MailRepository>();

            services.AddDbContext<MailContext>(builder => builder.UseSqlServer(connectionString));
        }
    }
}
