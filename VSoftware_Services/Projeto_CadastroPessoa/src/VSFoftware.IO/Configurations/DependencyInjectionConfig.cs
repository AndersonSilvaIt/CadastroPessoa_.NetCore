using Microsoft.Extensions.DependencyInjection;
using VSoftware.Business.Interfaces;
using VSoftware.Business.Notificacoes;
using VSoftware.Business.Servicos;
using VSoftware.Data.Contexto;
using VSoftware.Data.Repository.Repositorios;

namespace VSoftware.IO.Configurations
{
	public static class DependencyInjectionConfig
	{
		public static IServiceCollection ResolveDependencies(this IServiceCollection services)
		{
			services.AddScoped<VSContext>();
			services.AddScoped<IPessoaRepository, PessoaRepository>();
			services.AddScoped<INotificador, Notificador>();
			services.AddScoped<IPessoaService, PessoaService>();

			return services;
		}
	}
}
