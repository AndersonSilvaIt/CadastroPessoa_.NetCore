using FluentValidation;
using FluentValidation.Results;
using VSoftware.Business.Interfaces;
using VSoftware.Business.Models;
using VSoftware.Business.Notificacoes;

namespace VSoftware.Business.MediatorHandlers
{
	public abstract class BaseHandler
	{
		private readonly INotificador _notificador;

		public BaseHandler(INotificador notificador)
		{
			_notificador = notificador;
		}

		protected void Notificar(ValidationResult validationResult)
		{
			foreach (var item in validationResult.Errors)
			{
				Notificar(item.ErrorMessage);
			}
		}

		protected void Notificar(string mensagem)
		{
			_notificador.Handle(new Notificacao(mensagem));
		}

		protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
		{
			var validator = validacao.Validate(entidade);
			if (validator.IsValid) return true;

			Notificar(validator);
			return false;
		}

	}
}
