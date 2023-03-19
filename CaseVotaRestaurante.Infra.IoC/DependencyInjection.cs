using CaseVotaRestaurante.Application.Interfaces;
using CaseVotaRestaurante.Application.Mappings;
using CaseVotaRestaurante.Application.Services;
using CaseVotaRestaurante.Domain.Interface;
using CaseVotaRestaurante.Infra.Data.Context;
using CaseVotaRestaurante.Infra.Data.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaseVotaRestaurante.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IVoteRepository, VoteRespository>();
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IPeopleService, PeopleService>();
            services.AddScoped<IVoteService, VoteService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
