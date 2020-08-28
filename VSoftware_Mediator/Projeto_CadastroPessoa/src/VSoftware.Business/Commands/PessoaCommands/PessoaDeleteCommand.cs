using MediatR;

namespace VSoftware.Business.Commands.PessoaCommands
{
	public class PessoaDeleteCommand : IRequest<string>
	{
		public int Id { get; set; }
	}
}
