using Microsoft.EntityFrameworkCore;
using System.Linq;
using VSoftware.Business.Models;

namespace VSoftware.Data.Contexto
{
	public class VSContext : DbContext
	{
		public VSContext(DbContextOptions options) : base(options)
		{ }

		public DbSet<Pessoa> Pessoas { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			/*Caso não for mapeado alguma propriedade, aqui é setado como default o tipo dela*/
			foreach (var property in modelBuilder.Model.GetEntityTypes()
											.SelectMany(e => e.GetProperties()
											.Where(p => p.ClrType == typeof(string))))
			{
				property.SetColumnType("varchar(200)");
			}

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(VSContext).Assembly);

			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.EnableSensitiveDataLogging();

			base.OnConfiguring(optionsBuilder);
		}

	}
}
