using Microsoft.EntityFrameworkCore;
using MyBody.Application.Services.Contracts;


namespace MyBody.infra.Data.Repositories
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            DbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(TId id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            return (await DbSet.AddAsync(entity)).Entity;
        }

        //public TEntity Update(TEntity entity)
        //{
     
        //    var existingEntity = DbSet.Find((object)(entity.GetType().GetProperty("Id")?.GetValue(entity)));

        //    // Atualizar os valores da entidade existente 
        //    _context.Entry(existingEntity).CurrentValues.SetValues(entity);

        //    return existingEntity;
        //}


        public TEntity Update(TEntity entity)
        {
            return (DbSet.Update(entity)).Entity;
        }


        public TEntity Delete(TEntity entity)
        {
            return (DbSet.Remove(entity)).Entity;
        }

        public async Task<TEntity> Delete(TId id)
        {
            var entity = await GetById(id);
            return Delete(entity);
        }


    }
}
