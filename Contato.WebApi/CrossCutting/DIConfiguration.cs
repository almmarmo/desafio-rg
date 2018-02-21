using Contato.Application.Service;
using Contato.Infra.Service;
using Contrato.Domain.Repository;
using Contrato.Domain.Service;
using Contrato.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contato.WebApi.CrossCutting
{
    public static class DIConfiguration
    {
        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddScoped<IContatoRepository, ContatoMemoryRepository>();
            services.AddScoped<IContatoService, ContatoService>();
            services.AddScoped<IContatoApplicationService, ContatoApplicationService>();
        }
    }
}
