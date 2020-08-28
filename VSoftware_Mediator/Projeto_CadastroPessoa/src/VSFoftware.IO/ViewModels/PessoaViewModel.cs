using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VSoftware.IO.ViewModels
{
	public class PessoaViewModel
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
		public string Nome { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		public int Idade { get; set; }

		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(11, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
		public string Documento { get; set; }

		[DisplayName("Sexo")]
		public int OpcaoSexual { get; set; }

		[DisplayName("Data de Nascimento")]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		[DataType(DataType.Date)]
		public DateTime DataNascimento { get; set; }

		[DisplayName("Profissão")]
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
		public string Profissao { get; set; }
	}
}
