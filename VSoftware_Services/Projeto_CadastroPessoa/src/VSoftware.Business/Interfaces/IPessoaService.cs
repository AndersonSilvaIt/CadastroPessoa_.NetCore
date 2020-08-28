using System.Collections.Generic;
using System.Threading.Tasks;
using VSoftware.Business.Models;

namespace VSoftware.Business.Interfaces
{
	public interface IPessoaService
	{
		Task Adicionar(Pessoa pessoa);
		Task Atualizar(Pessoa pessoa);
		Task Remover(int id);
		Task<IEnumerable<Pessoa>> Buscar(string nome, string documento);
	}
}
