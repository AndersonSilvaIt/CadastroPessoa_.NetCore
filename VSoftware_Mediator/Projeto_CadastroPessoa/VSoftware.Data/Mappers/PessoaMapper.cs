using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VSoftware.Business.Models;

namespace VSoftware.Data.Mappers
{
	public class PessoaMapper : IEntityTypeConfiguration<Pessoa>
	{
		public void Configure(EntityTypeBuilder<Pessoa> builder)
		{
			builder.HasKey(p => p.Id);
			builder.Property(x => x.Nome)
				.IsRequired()
				.HasColumnType("varchar(200)");

			builder.Property(x => x.Documento)
				.IsRequired()
				.HasColumnType("varchar(20)");

			builder.Property(x => x.Idade)
				.IsRequired()
				.HasColumnType("integer");

			builder.Property(x => x.OpcaoSexual)
				.IsRequired()
				.HasColumnType("integer");

			builder.Property(x => x.DataNascimento)
				.IsRequired()
				.HasColumnType("DateTime");

			builder.Property(x => x.Profissao)
				.IsRequired()
				.HasColumnType("varchar(200)");

			builder.ToTable("Pessoas");
		}
	}
}
