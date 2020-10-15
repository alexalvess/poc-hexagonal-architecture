using Domain.Adapters;
using Infra.DataBase.InMemory.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DataBase.InMemory
{
    public static class DataBaseInMemoryModuleDependency
    {
        public static void AddDataBaseInMemoryModule(this IServiceCollection services)
        {
            services.AddScoped<IClubRepository, ClubRepository>();
        }
    }
}
