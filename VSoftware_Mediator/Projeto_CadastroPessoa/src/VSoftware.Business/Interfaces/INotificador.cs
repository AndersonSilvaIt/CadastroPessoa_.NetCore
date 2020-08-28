using System.Collections.Generic;
using VSoftware.Business.Notificacoes;

namespace VSoftware.Business.Interfaces
{
	public interface INotificador
	{
		bool TemNotificacao();
		List<Notificacao> ObterNotificacoes();
		void Handle(Notificacao notificacao);
	}
}
