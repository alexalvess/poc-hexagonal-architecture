using Domain.Adapters;
using Infra.Email.Operations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Email
{
    public static class EmailModuleDependency
    {
        public static void AddEmailModule(this IServiceCollection services)
        {
            services.AddTransient<IEmailAdapter, EmailManager>();
        }
    }
}
