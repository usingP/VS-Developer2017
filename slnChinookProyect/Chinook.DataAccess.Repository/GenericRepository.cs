using Chinook.DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        public GenericRepository(DbContext pContext)
        {
            this.context = pContext;
        }

        public void add(TEntity entity)
        {
            this.context.Set<TEntity>().Add(entity);
            //throw new NotImplementedException();
        }

        public int Count()
        {
            return this.context.Set<TEntity>().Count();
            //throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>().ToList();
            //throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            return this.context.Set<TEntity>().Find(id);
            //throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            this.context.Set<TEntity>().Attach(entity);
            this.context.Set<TEntity>().Remove(entity);
            //throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            this.context.Set<TEntity>().Attach(entity);
            this.context.Entry<TEntity>(entity).State = EntityState.Modified;
        }
    }
}
