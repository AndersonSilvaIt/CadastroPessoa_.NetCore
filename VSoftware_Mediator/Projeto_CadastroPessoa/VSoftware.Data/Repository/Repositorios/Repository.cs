using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VSoftware.Business.Interfaces;
using VSoftware.Business.Models;
using VSoftware.Data.Contexto;

namespace VSoftware.Data.Repository.Repositorios
{
	public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
	{
		protected readonly VSContext Db;
		protected readonly DbSet<TEntity> DbSet;
		public Repository(VSContext db)
		{
			Db = db;
			DbSet = db.Set<TEntity>();
		}

		public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
		{
			return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
		}

		public virtual async Task<TEntity> ObterPorId(int id)
		{
			return await DbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
		}

		public virtual async Task<IEnumerable<TEntity>> ObterTodos()
		{

			return await DbSet.AsNoTracking().ToListAsync();
		}

		public virtual async Task Adicionar(TEntity entity)
		{
			DbSet.Add(entity);
			await SaveChanges();
		}

		public virtual async Task Atualizar(TEntity entity)
		{

			DbSet.Update(entity);
			await SaveChanges();
		}

		public virtual async Task Remover(int id)
		{
			var entity = new TEntity { Id = id };
			DbSet.Remove(entity);
			await SaveChanges();
		}

		public async Task<int> SaveChanges()
		{
			return await Db.SaveChangesAsync();
		}

		public void Dispose()
		{
			Db?.Dispose();
		}

	}
}
