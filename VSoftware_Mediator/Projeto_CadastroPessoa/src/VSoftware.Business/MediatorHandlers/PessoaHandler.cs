using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VSoftware.Business.Commands.PessoaCommands;
using VSoftware.Business.Interfaces;
using VSoftware.Business.Models;
using VSoftware.Business.Models.Validations;

namespace VSoftware.Business.MediatorHandlers
{
	public class PessoaHandler : BaseHandler, 
		IRequestHandler<PessoaCreateCommand, string>,
		IRequestHandler<PessoaUpdateCommand, string>,
		IRequestHandler<PessoaDeleteCommand, string>
	{
		private readonly IPessoaRepository _pessoaRepository;
		public PessoaHandler(IPessoaRepository pessoaRepository,
					 INotificador notificador) : base(notificador)
		{
			_pessoaRepository = pessoaRepository;
		}

		public async Task<string> Handle(PessoaCreateCommand request, CancellationToken cancellationToken)
		{
			Pessoa p = new Pessoa() { 
				Nome = request.Nome, 
				Idade = request.Idade, 
				DataNascimento = request.DataNascimento, 
				Documento = request.Documento, 
				OpcaoSexual = (TipoSexo)request.OpcaoSexual, 
				Profissao = request.Profissao };

			if (!ExecutarValidacao(new PessoaValidation(), p)) return await Task.FromResult("Erro"); ;

			if (_pessoaRepository.Buscar(p => p.Documento == p.Documento).Result.Any())
			{
				Notificar("Já existe uma pessoa com este documento informado.");
				await Task.FromResult("");
			}

			await _pessoaRepository.Adicionar(p);

			return await Task.FromResult("");
		}

		public async Task<string> Handle(PessoaUpdateCommand request, CancellationToken cancellationToken)
		{
			Pessoa p1 = new Pessoa()
			{
				Id =  request.Id,
				Nome = request.Nome,
				Idade = request.Idade,
				DataNascimento = request.DataNascimento,
				Documento = request.Documento,
				OpcaoSexual = (TipoSexo)request.OpcaoSexual,
				Profissao = request.Profissao
			};

			if (!ExecutarValidacao(new PessoaValidation(), p1)) 
				return await Task.FromResult("Erro");

			if (_pessoaRepository.Buscar(p => p.Documento == p1.Documento && p.Id != p1.Id).Result.Any())
			{
				Notificar("Já existe uma pessoa com este documento informado.");
				await Task.FromResult("");
			}

			await _pessoaRepository.Atualizar(p1);
			return await Task.FromResult("");
		}

		public async Task<string> Handle(PessoaDeleteCommand request, CancellationToken cancellationToken)
		{
			await _pessoaRepository.Remover(request.Id);
			return await Task.FromResult("");
		}
	}
}
