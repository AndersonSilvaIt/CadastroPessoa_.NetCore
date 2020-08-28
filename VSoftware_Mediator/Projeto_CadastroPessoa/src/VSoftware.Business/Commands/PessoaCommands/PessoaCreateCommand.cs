using MediatR;
using System;

namespace VSoftware.Business.Commands.PessoaCommands
{
	public class PessoaCreateCommand : IRequest<string>
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Idade { get; set; }
		public string Documento { get; set; }
		public int OpcaoSexual { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Profissao { get; set; }
	}
}
