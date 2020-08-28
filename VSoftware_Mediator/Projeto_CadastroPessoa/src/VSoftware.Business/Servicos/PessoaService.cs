using System.Collections.Generic;
using System.Threading.Tasks;
using VSoftware.Business.Interfaces;
using VSoftware.Business.Models;

namespace VSoftware.Business.Servicos
{
	public class PessoaService: BaseService, IPessoaService
	{
		private readonly IPessoaRepository _pessoaRepository;
		public PessoaService(IPessoaRepository pessoaRepository,
			INotificador notificador) : base(notificador)
		{
			_pessoaRepository = pessoaRepository;
		}

		public Task<IEnumerable<Pessoa>> Buscar(string nome, string documento)
		{
			nome = nome == null ? "" : nome;
			documento = documento == null ? "" : documento;

			return _pessoaRepository.Buscar(p => p.Nome.Contains(nome) && p.Documento.Contains(documento));
		}

	}
}
