﻿using Microsoft.Extensions.DependencyInjection;

namespace VSoftware.IO.Configurations
{
	public static class ConfiguracaoMVC
	{
		public static IServiceCollection AddMvcConfiguration(this IServiceCollection services)
		{
			services.AddMvc(options => {
				options.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor((x, y) => "O valor preenchido é inválido para este campo.");
				options.ModelBindingMessageProvider.SetMissingBindRequiredValueAccessor(x => "Este campo precisa ser preenchido.");
				options.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => "Este campo precisa ser preenchido.");
				options.ModelBindingMessageProvider.SetMissingRequestBodyRequiredValueAccessor(() => "É necessário que o body na requisição não esteja vazio.");
				options.ModelBindingMessageProvider.SetNonPropertyAttemptedValueIsInvalidAccessor((x) => "O valor preenchidoé inválido para teste campo.");
				options.ModelBindingMessageProvider.SetNonPropertyUnknownValueIsInvalidAccessor(() => "O valor preenchidoé inválido para teste campo.");
				options.ModelBindingMessageProvider.SetNonPropertyValueMustBeANumberAccessor(() => "O campo deve ser numérico.");
				options.ModelBindingMessageProvider.SetUnknownValueIsInvalidAccessor((x) => "O valor preenchido é inválido para este campo.");
				options.ModelBindingMessageProvider.SetValueIsInvalidAccessor((x) => "O valor preenchido é inválido para este campo.");
				options.ModelBindingMessageProvider.SetValueMustBeANumberAccessor(x => "O campo deve ser numérico");
				options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(x => "Este campo precisa ser preenchido.");
			}
		);

			return services;
		}

	}
}
