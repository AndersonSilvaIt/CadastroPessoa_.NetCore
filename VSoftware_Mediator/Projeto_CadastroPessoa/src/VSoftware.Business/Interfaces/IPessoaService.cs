using System.Collections.Generic;
using System.Threading.Tasks;
using VSoftware.Business.Models;

namespace VSoftware.Business.Interfaces
{
	public interface IPessoaService
	{
		Task<IEnumerable<Pessoa>> Buscar(string nome, string documento);
	}
}
