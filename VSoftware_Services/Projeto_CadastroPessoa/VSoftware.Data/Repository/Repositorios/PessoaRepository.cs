using VSoftware.Business.Interfaces;
using VSoftware.Business.Models;
using VSoftware.Data.Contexto;

namespace VSoftware.Data.Repository.Repositorios
{
	public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
	{
		public PessoaRepository(VSContext contexto) : base(contexto)
		{
		}

	}
}
