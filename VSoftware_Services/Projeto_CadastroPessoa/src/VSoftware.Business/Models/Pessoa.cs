using System;

namespace VSoftware.Business.Models
{
	public class Pessoa : Entity
	{
		public string Nome { get; set; }
		public string Documento { get; set; }
		public DateTime DataNascimento { get; set; }
		public int Idade { get; set; }
		public TipoSexo OpcaoSexual { get; set; }
		public string Profissao { get; set; }
	}
}
