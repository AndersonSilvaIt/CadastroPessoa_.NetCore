using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VSoftware.Business.Interfaces;
using VSoftware.Business.Models;
using VSoftware.Business.Models.Validations;

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

		public async Task Adicionar(Pessoa pessoa)
		{
			if (!ExecutarValidacao(new PessoaValidation(), pessoa)) return;

			if (_pessoaRepository.Buscar(p => p.Documento == pessoa.Documento).Result.Any())
			{
				Notificar("Já existe uma pessoa com este documento informado.");
				return;
			}

			await _pessoaRepository.Adicionar(pessoa);
		}

		public async Task Atualizar(Pessoa pessoa)
		{
			if (!ExecutarValidacao(new PessoaValidation(), pessoa)) return;

			if (_pessoaRepository.Buscar(p => p.Documento == pessoa.Documento && p.Id != pessoa.Id).Result.Any())
			{
				Notificar("Já existe uma pessoa com este documento informado.");
				return;
			}

			await _pessoaRepository.Atualizar(pessoa);
		}

		public Task<IEnumerable<Pessoa>> Buscar(string nome, string documento)
		{
			nome = nome == null ? "" : nome;
			documento = documento == null ? "" : documento;

			return _pessoaRepository.Buscar(p => p.Nome.Contains(nome) && p.Documento.Contains(documento));
		}

		public async Task Remover(int id)
		{
			await _pessoaRepository.Remover(id);
		}
	}
}
